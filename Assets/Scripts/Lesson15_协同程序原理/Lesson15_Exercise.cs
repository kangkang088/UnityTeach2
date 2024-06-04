using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson15_Exercise : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        CoRoutineMgr.Instance.MyStartCoroutine(MyTest());
    }

    // Update is called once per frame
    void Update() {

    }
    IEnumerator MyTest() {
        print("1");
        yield return 1;
        print("2");
        yield return 2;
        print("3");
        yield return 3;
        print("4");
    }
    void MyStartCoroutine(IEnumerator ie) {
        
    }
}
