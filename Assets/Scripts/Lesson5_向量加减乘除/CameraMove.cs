using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {
    public Transform target;

    private Vector3 targetPos;
    public float moveSpeed;
    private float time;
    private Vector3 startPos;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    private Quaternion targetQ;
    private float roundTime;
    private Quaternion start;
    private void LateUpdate() {

        //this.transform.position = target.position + new Vector3(0, 7, -4);
        //if (targetPos != target.position + -target.forward * 4 + target.up * 7) {
        //    targetPos = target.position + -target.forward * 4 + target.up * 7;
        //}
        //this.transform.position = Vector3.Lerp(this.transform.position, targetPos, Time.deltaTime * moveSpeed);
        //this.transform.LookAt(target);

        if (targetPos != target.position + -target.forward * 4 + target.up * 7) {
            targetPos = target.position + -target.forward * 4 + target.up * 7;
            startPos = this.transform.position;
            time = 0;
        }
        time += Time.deltaTime;
        this.transform.position = Vector3.Lerp(startPos, targetPos, time * moveSpeed);

        //targetQ = Quaternion.LookRotation(target.position - this.transform.position);
        //this.transform.rotation = Quaternion.Slerp(this.transform.rotation, targetQ, Time.deltaTime);
        if (targetQ != Quaternion.LookRotation(target.position - this.transform.position)) {
            roundTime = 0;
            start = this.transform.rotation;
            targetQ = Quaternion.LookRotation(target.position - this.transform.position);
        }
        roundTime += Time.deltaTime;
        this.transform.rotation = Quaternion.Slerp(start, targetQ, roundTime);
    }
}
