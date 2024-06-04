﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour {
    public Transform target;
    public Transform A;
    public Transform B;
    public Transform C;
    private float time;
    private Vector3 startPos;
    private Vector3 nowPos;
    private void Start() {
        startPos = B.position;
    }
    // Update is called once per frame
    void Update() {
        A.position = Vector3.Lerp(A.position, target.position, Time.deltaTime);
        if (nowPos != target.position) {
            nowPos = target.position;
            time = 0;
            startPos = B.position;
        }
        time += Time.deltaTime;
        B.position = Vector3.Lerp(startPos, nowPos, time);
        C.position = Vector3.Slerp(Vector3.right * 10, Vector3.left * 10 + Vector3.up * 0.1f, time * 0.1f);
    }
}
