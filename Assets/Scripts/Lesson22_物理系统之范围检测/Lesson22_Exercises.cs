using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson22_Exercises : MonoBehaviour {
    public float moveSpeed;
    public float rotateSpeed;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.J)) {
            Collider[] colliders = Physics.OverlapBox(this.transform.position + this.transform.forward * 1, Vector3.one);
            for (int i = 0; i < colliders.Length; i++) {
                print("物体受伤");
                print(colliders[i].gameObject.name);
            }
        }
        if (Input.GetKeyDown(KeyCode.K)) {
            Collider[] colliders = Physics.OverlapCapsule(this.transform.position, this.transform.position + Vector3.forward * 5, 0.5f, 1 << LayerMask.NameToLayer("Monster"));
            for (int i = 0; i < colliders.Length; i++) {
                print("物体受伤");
                print(colliders[i].gameObject.name);
            }
        }
        if (Input.GetKeyDown(KeyCode.L)) {
            Collider[] colliders = Physics.OverlapSphere(this.transform.position, 10, 1 << LayerMask.NameToLayer("Monster"));
            for (int i = 0; i < colliders.Length; i++) {
                print("物体受伤");
                print(colliders[i].gameObject.name);
            }
        }
    }
}
