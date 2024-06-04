using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson21 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        GameObject line = new GameObject();
        line.name = "Line";
        LineRenderer renderer = line.AddComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update() {

    }
}
