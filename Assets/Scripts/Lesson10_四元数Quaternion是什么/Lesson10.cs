using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Quaternion q = new Quaternion(Mathf.Sin(60 * Mathf.Deg2Rad / 2) * 1, 0, 0, Mathf.Cos(60 * Mathf.Deg2Rad / 2));
    }

    // Update is called once per frame
    void Update() {

    }
}
