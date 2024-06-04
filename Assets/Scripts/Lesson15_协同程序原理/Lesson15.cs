using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClass {
    public int time;
    public TestClass(int time) {
        this.time = time;
    }
}
public class Lesson15 : MonoBehaviour {
    IEnumerator Test() {
        print("第一次执行");
        yield return 1;
        print("第二次执行");
        yield return 2;
        print("第三次执行");
        yield return "123";
        print("第四次执行");
        yield return new TestClass(5);
        print("第五次执行");
    }
    // Start is called before the first frame update
    void Start() {
        IEnumerator e = Test();
        while (e.MoveNext()) {
            print(e.Current);
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
