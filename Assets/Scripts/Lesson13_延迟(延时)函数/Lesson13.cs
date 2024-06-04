using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Invoke("DelayDoSomething", 5);
    }
    private void DelayDoSomething() {
        print("延时打印函数");
    }
    // Update is called once per frame
    void Update() {

    }
}
