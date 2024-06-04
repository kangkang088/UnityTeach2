using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson20_Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneMgr.Instance.LoadScene("Lesson20_Test", () => {
            print("加载完成");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
