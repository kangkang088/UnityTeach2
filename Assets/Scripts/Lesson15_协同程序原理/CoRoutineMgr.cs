using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YieldReturnTime {
    public IEnumerator ie;
    public float time;
}
public class CoRoutineMgr : MonoBehaviour {
    private static CoRoutineMgr instance;
    public static CoRoutineMgr Instance => instance;

    private List<YieldReturnTime> list = new List<YieldReturnTime>();
    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start() {

    }
    public void MyStartCoroutine(IEnumerator ie) {
        if (ie.MoveNext()) {
            if (ie.Current is int) {
                YieldReturnTime y = new YieldReturnTime();
                y.ie = ie;
                y.time = Time.time + (int)ie.Current;
                list.Add(y);
            }
        }
    }
    // Update is called once per frame
    void Update() {
        for (int i = list.Count - 1; i >= 0; i--) {
            if (list[i].time <= Time.time) {
                if (list[i].ie.MoveNext()) {
                    if (list[i].ie.Current is int) {
                        list[i].time = (int)list[i].ie.Current + Time.time;
                    } else {
                        list.RemoveAt(i);
                    }
                } else {
                    list.RemoveAt(i);
                }
            }
        }
    }
}
