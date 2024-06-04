using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson23_Exercises : MonoBehaviour {
    RaycastHit info;
    private Transform nowSel;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        #region pratice1
        //if (Input.GetMouseButtonDown(0)) {
        //    if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),
        //                        out info,
        //                        1000,
        //                        1 << LayerMask.NameToLayer("Monster"))) {
        //        GameObject obj = Instantiate(Resources.Load<GameObject>("Effects/HitEff"));
        //        obj.transform.position = info.point + info.normal * 0.2f;
        //        obj.transform.rotation = Quaternion.LookRotation(info.normal);
        //        Destroy(obj, 0.8f);
        //        obj = Instantiate(Resources.Load<GameObject>("Effects/BulletHole"));
        //        obj.transform.position = info.point + info.normal * 0.2f;
        //        obj.transform.rotation = Quaternion.LookRotation(info.normal);
        //    }
        //}
        #endregion
        #region pratice2
        if (Input.GetMouseButtonDown(0)) {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out info, 1000, 1 << LayerMask.NameToLayer("Player"))) {
                nowSel = info.transform;
                //print(nowSel.gameObject.name);
            }
        }
        if(Input.GetMouseButton(0) && nowSel != null) {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out info, 1000, 1 << LayerMask.NameToLayer("Floor"))) {
                nowSel.position = info.point + Vector3.up * 0.5f;
            }
        }
        if (Input.GetMouseButtonDown(1)) {
            nowSel = null;
        }
        #endregion

    }
}
