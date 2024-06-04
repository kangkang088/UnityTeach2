using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Fire_Type {
    One, Two, Three, Round
}
public class Airplane : MonoBehaviour {
    private E_Fire_Type nowType = E_Fire_Type.One;
    // Start is called before the first frame update
    private GameObject bullet;
    public int roundNum = 4;
    void Start() {
        bullet = Resources.Load<GameObject>("Bullet");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            nowType = E_Fire_Type.One;
        } else if (Input.GetKeyDown(KeyCode.Alpha2)) {
            nowType = E_Fire_Type.Two;
        } else if (Input.GetKeyDown(KeyCode.Alpha3)) {
            nowType = E_Fire_Type.Three;
        } else if (Input.GetKeyDown(KeyCode.Alpha4)) {
            nowType = E_Fire_Type.Round;
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Fire();
        }
    }

    private void Fire() {
        switch (nowType) {
            case E_Fire_Type.One:
                Instantiate(bullet, this.transform.position, this.transform.rotation);
                break;
            case E_Fire_Type.Two:
                Instantiate(bullet, this.transform.position + -this.transform.right * 0.5f, this.transform.rotation);
                Instantiate(bullet, this.transform.position + this.transform.right * 0.5f, this.transform.rotation);
                break;
            case E_Fire_Type.Three:
                Instantiate(bullet, this.transform.position, this.transform.rotation);
                Instantiate(bullet, this.transform.position, this.transform.rotation * Quaternion.AngleAxis(-20, Vector3.up));
                Instantiate(bullet, this.transform.position, this.transform.rotation * Quaternion.AngleAxis(+20, Vector3.up));
                break;
            case E_Fire_Type.Round:
                float angle = 360 / roundNum;
                for (int i = 0; i < roundNum; i++) {
                    Instantiate(bullet, this.transform.position, this.transform.rotation * Quaternion.AngleAxis(i * angle, Vector3.up));
                }
                break;
        }
    }
}
