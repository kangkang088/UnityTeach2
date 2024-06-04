using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18_Test : MonoBehaviour {
    private Texture tex;
    // Start is called before the first frame update
    void Start() {
        ResourcesMgr.Instance.LoadRes<Texture>("Tex/guidao", (o) => {
            tex = o;
        });
    }
    private void OnGUI() {
        if (tex != null)
            GUI.DrawTexture(new Rect(0, 0, 100, 100), tex);
    }
    // Update is called once per frame
    void Update() {

    }
}
