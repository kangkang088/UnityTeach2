using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy : MonoBehaviour {
    public Transform target;
    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(this.transform.position, target.transform.position) <= 5) {
            float dotResult = Vector3.Dot(this.transform.forward, (target.transform.position - this.transform.position).normalized);
            if (Mathf.Acos(dotResult) * Mathf.Rad2Deg <= 22.5f) {
                print("发现入侵者");
            }
        }
    }
}
