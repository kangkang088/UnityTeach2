﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Exercises : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        StartCoroutine(MyCoroutine());
    }
    IEnumerator MyCoroutine() {
        int time = 0;
        while (true) {
            print(time + "秒");
            time++;
            yield return new WaitForSeconds(1);
        }
    }
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            //for (int i = 0; i < 100000; i++) {
            //    GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            //    obj.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
            //}
            StartCoroutine(CreateCube(100000));
        }
    }
    IEnumerator CreateCube(int num) {
        for (int i = 0; i < num; i++) {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            obj.transform.position = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
            if (i % 1000 == 0)
                yield return null;
        }
    }
}
