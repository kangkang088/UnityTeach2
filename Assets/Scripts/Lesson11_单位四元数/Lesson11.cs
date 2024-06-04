using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour {
    public Transform testObj;

    public Transform target;
    public Transform A;
    public Transform B;
    private Quaternion start;
    private float time;
    public Transform LookA;
    public Transform LookB;
    // Start is called before the first frame update
    void Start() {
        print(Quaternion.identity);
        //testObj.rotation = Quaternion.identity;
        start = B.transform.rotation;

        //LookA.transform.rotation = Quaternion.LookRotation(LookB.position - LookA.position);
        LookA.MyLookAt(LookB);
    }

    // Update is called once per frame
    void Update() {
        A.transform.rotation = Quaternion.Slerp(A.transform.rotation, target.transform.rotation, Time.deltaTime);
        time += Time.deltaTime;
        B.transform.rotation = Quaternion.Slerp(start, target.transform.rotation, time);
    }
}
