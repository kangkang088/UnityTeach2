using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Ray r = new Ray(Vector3.right, Vector3.forward);
        Ray cr = Camera.main.ScreenPointToRay(Input.mousePosition);
    }

    // Update is called once per frame
    void Update() {

    }
}
