using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson18 : MonoBehaviour {
    private Texture tex;
    // Start is called before the first frame update
    void Start() {
        ResourceRequest resourceRequest = Resources.LoadAsync<Texture>("Tex/guidao");
        resourceRequest.completed += LoadOver;
    }

    private void LoadOver(AsyncOperation obj) {
        print("加载完毕！");
        tex = (obj as ResourceRequest).asset as Texture;
    }
    IEnumerator Load() {
        ResourceRequest resourceRequest = Resources.LoadAsync<Texture>("Tex/guidao");
        yield return null;
        yield return new WaitForSeconds(2f);
    }

    // Update is called once per frame
    void Update() {

    }
    private void OnGUI() {
        if (tex != null)
            GUI.DrawTexture(new Rect(0, 0, 100, 100), tex);
    }
}
