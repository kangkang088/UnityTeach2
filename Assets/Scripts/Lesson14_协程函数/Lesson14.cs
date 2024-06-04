using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        IEnumerator ie = MyCoroutine(1, "123");
        StartCoroutine(MyCoroutine(1, "123"));
        StartCoroutine(MyCoroutine(1, "123"));
        StartCoroutine(MyCoroutine(1, "123"));
        StopAllCoroutines();
    }

    // Update is called once per frame
    void Update() {

    }
    //返回值必须是IEnumerator或继承它的
    IEnumerator MyCoroutine(int i, string str) {
        print(i);
        yield return new WaitForSeconds(5f);
        print(str);
    }
}
