using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//VR使わない時用のマウスでカメラを操作するスクリプトです
//不要であれば外してください
//佐藤
public class cameramove : MonoBehaviour {
    public Camera MainCamera;
    private Vector3 lastMousePosition;
    private Vector3 newAngle = new Vector3(0, 0, 0);
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            //スペースキーでカメラの角度を保持(後ろ向く用)
            newAngle = MainCamera.transform.localEulerAngles;
            lastMousePosition = Input.mousePosition;
        }
        else 
        {
            // マウスの移動量分カメラを回転させる
            newAngle.y -= (Input.mousePosition.x - lastMousePosition.x) * 0.1f;
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * 0.1f;
            MainCamera.gameObject.transform.localEulerAngles = newAngle;

            lastMousePosition = Input.mousePosition;
        }

    }
}
