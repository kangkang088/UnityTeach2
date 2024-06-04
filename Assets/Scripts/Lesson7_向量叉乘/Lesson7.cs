using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour {
    public Transform a;
    public Transform b;
    // Start is called before the first frame update
    void Start() {
        print(Vector3.Cross(a.transform.position, b.transform.position));
    }

    // Update is called once per frame
    void Update() {

    }
}
