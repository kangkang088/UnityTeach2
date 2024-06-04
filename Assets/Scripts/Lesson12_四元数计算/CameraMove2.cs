using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove2 : MonoBehaviour {
    public Transform target;
    public float headOffsetH = 1;
    public float angle = 45;
    public float distance = 5;
    public float maxDis = 10;
    public float minDis = 3;

    private Vector3 nowPos;
    // Start is called before the first frame update
    void Start() {

    }
    private Vector3 nowDir;
    public float lookAtSpeed = 2;
    public float moveSpeed = 2;
    // Update is called once per frame
    void Update() {
        distance += Input.GetAxis("Mouse ScrollWheel");
        distance = Mathf.Clamp(distance, minDis, maxDis);
        //得到头顶偏移位置
        nowPos = target.position + target.up * headOffsetH;
        //后方偏移位置
        nowDir = Quaternion.AngleAxis(angle, Vector3.right) * -target.forward;
        nowPos = nowPos + nowDir * distance;
        //直接赋值
        //this.transform.position = nowPos;
        //lerp
        this.transform.position = Vector3.Lerp(this.transform.position, nowPos, Time.deltaTime * moveSpeed);
        Debug.DrawLine(this.transform.position, target.position + target.up * headOffsetH,Color.green);
        //缓动
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(-nowDir), Time.deltaTime * lookAtSpeed);
    }
}
