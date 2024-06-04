using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21_Exercises : MonoBehaviour {
    private LineRenderer line2;
    private Vector3 nowPos;
    // Start is called before the first frame update
    void Start() {
        DrawLineRenderer(new Vector3(0, 0, 0), 5, 360);
        line2 = this.gameObject.AddComponent<LineRenderer>();
        line2.loop = false;
        line2.startWidth = 0.5f;
        line2.endWidth = 0.5f;
        line2.positionCount = 0;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButton(0)) {
            line2.positionCount += 1;
            nowPos = Input.mousePosition;
            nowPos.z = 10;
            line2.SetPosition(line2.positionCount - 1, Camera.main.ScreenToWorldPoint(nowPos));
        }
    }
    public void DrawLineRenderer(Vector3 centerPos, float radius,int numPoint) {
        GameObject obj = new GameObject();
        obj.name = "Circle";
        LineRenderer lineRenderer = obj.AddComponent<LineRenderer>();
        lineRenderer.loop = true;
        lineRenderer.positionCount = numPoint;
        float angle = 360 / numPoint;
        for (int i = 0; i < numPoint; i++) {
            lineRenderer.SetPosition(i, centerPos + Quaternion.AngleAxis(angle * i, Vector3.up) * Vector3.forward * radius);
        }
    }
}
