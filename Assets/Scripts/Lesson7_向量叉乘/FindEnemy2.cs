using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindEnemy2 : MonoBehaviour {
    public Transform A;
    public Transform B;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Dot(A.forward, B.position - A.position) >= 0) {
            if (Vector3.Cross(A.forward, B.position - A.position).y >= 0) {
                print("右前");
            } else {
                print("左前");
            }
        } else {
            if (Vector3.Cross(A.forward, B.position - A.position).y >= 0) {
                print("右后");
            } else {
                print("右后");
            }
        }
    }
}
