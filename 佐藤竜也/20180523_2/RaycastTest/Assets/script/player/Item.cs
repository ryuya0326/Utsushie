using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {
    public static GameObject GetItem;
    [SerializeField]
    ItemGet itemget;
	[SerializeField]
	Itemuse itemuse;
    //一回だけ呼ばれる
    public int itemget_once = 0;
    //cameraに入ったときに呼ばれる
    void OnWillRenderObject()
    {
        //ItemGetモードの時にtrueになる関数
        bool cameramode = itemget.cameramode;

        /*ゲームのSceneCameraに映った時のみ呼ばれる
        （SceneViewのCameraでも反応するのを防ぐ）*/
        if (Camera.current.name != "SceneCamera" 
            && Camera.current.name != "Preview Camera"
            && cameramode == true)
        {
            //Debug.Log(Camera.current.name); カメラ確認用
            //Itemゲットしたときの処理（マウスのクリック）
            if (Input.GetMouseButton(0))
            {				
                GetItem = gameObject;
                itemget.ItemList.Add(GetItem);
                if (itemuse.itemget_once == 0)
                {
                    itemuse.itemget_once++;
                }
				GetItem.SetActive(false);
                Destroy(this);
            }
        }
    }
}