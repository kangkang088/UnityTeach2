using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Quaternion q = Quaternion.AngleAxis(20, Vector3.up);
        this.transform.rotation *= q;
    }

    // Update is called once per frame
    void Update() {

    }
}
