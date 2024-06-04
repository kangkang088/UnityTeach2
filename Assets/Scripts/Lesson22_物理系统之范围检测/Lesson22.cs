using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson22 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        Collider[] colliders = Physics.OverlapBox(Vector3.zero, Vector3.one, Quaternion.AngleAxis(45, Vector3.up), 1 << LayerMask.NameToLayer("UI") | 1 << LayerMask.NameToLayer("Default"), QueryTriggerInteraction.UseGlobal);
        //for (int i = 0; i < colliders.Length; i++) {
        //    print(colliders[i].gameObject.name);
        //}
        colliders = Physics.OverlapSphere(Vector3.zero, 5, 1 << LayerMask.NameToLayer("Default"),QueryTriggerInteraction.UseGlobal);
        for (int i = 0; i < colliders.Length; i++) {
            print(colliders[i].gameObject.name);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
