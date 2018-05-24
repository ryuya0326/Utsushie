using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemGet : MonoBehaviour {
    //Cameraモードで使用するUI
    [SerializeField]
    Image panel;
    [SerializeField]
    public List<GameObject> ItemList;
    [SerializeField]
    RaycastMove Raycastmove;

    [SerializeField]
    public bool cameramode = false;

	// Update is called once per frame
	void Update () {
        //キーボードのZを押しっぱなしでCameraMode
        if (Input.GetKeyDown(KeyCode.Z))
        {
            cameramode = true;
            Raycastmove.MoveStop = true;
            panel.color = new Color(1.0f, 1.0f, 1.0f, 0.5f);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            cameramode = false;
            Raycastmove.MoveStop = false;
            panel.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        }
    }
}