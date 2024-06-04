using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.DrawLine(this.transform.position, this.transform.position + this.transform.forward, Color.red);
        Debug.DrawRay(this.transform.position, this.transform.forward, Color.red);
        Debug.DrawRay(this.transform.position, target.position - this.transform.position, Color.red);
        float dotResult =  Vector3.Dot(this.transform.forward, target.position - this.transform.position);
        if (dotResult >= 0) {
            print("前方");
        } else
            print("后方");
    }
}
