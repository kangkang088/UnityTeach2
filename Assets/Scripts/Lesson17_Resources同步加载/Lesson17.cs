using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    private Texture tex;
    // Start is called before the first frame update
    void Start()
    {
        Object obj = Resources.Load("Cube");
        Instantiate(obj);
        tex = Resources.Load("Tex/guidao") as Texture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnGUI() {
        GUI.DrawTexture(new Rect(0, 0, 100, 100), tex);
    }
}
