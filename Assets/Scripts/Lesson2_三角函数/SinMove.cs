using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinMove : MonoBehaviour {
    private Vector3 pos;
    public float moveSpeed = 5;
    public float changeSpeed = 2;
    public float changeSize = 0.5f;
    private float time;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        time += Time.deltaTime * changeSpeed;
        this.transform.Translate(Vector3.right * changeSize * Time.deltaTime * Mathf.Sin(time));
    }
}
