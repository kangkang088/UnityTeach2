using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson13_Exercises : MonoBehaviour {
    // Start is called before the first frame update
    private int time = 0;
    void Start() {
        InvokeRepeating("DelayFunction", 0, 1);
    }

    // Update is called once per frame
    void Update() {

    }
    void DelayFunction() {
        print("time : " + time);
        time++;
    }
}
