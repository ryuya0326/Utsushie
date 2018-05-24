using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Itemuse : MonoBehaviour {
    [SerializeField]
    Item item;
    [SerializeField]
    ItemGet itemget;
    [SerializeField]
    RaycastMove Raycastmove;
    [SerializeField]
    GameObject ItemObjPos;

    //Rayの作成
    private RaycastHit hit;
    private Ray ray;
    public bool ItemUseMode = false;
	public int itemget_once = 0;

    int nowitemNum = 0;

    private void Update()
    {        
		Debug.Log (nowitemNum);
        if (itemget_once == 1)
        {
            itemget.ItemList[0].SetActive(true);
            itemget.ItemList[0].transform.position = ItemObjPos.transform.position;
            itemget_once++;
        }
        if (itemget.ItemList.Count >= 2)
        {
            //アイテム切り替え（W↑）
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (itemget.ItemList.Count > nowitemNum + 1)
                {
                    itemget.ItemList[nowitemNum].SetActive(false);
                    nowitemNum += 1;
                    itemget.ItemList[nowitemNum].SetActive(true);
                    itemget.ItemList[nowitemNum].transform.position = ItemObjPos.transform.position;
                }
            }
            //アイテム切り替え（S↓）
            if (Input.GetKeyDown(KeyCode.S))
            {
                if (itemget.ItemList.Count <= nowitemNum + 1)
                {
                    itemget.ItemList[nowitemNum].SetActive(false);
                    nowitemNum -= 1;
                    itemget.ItemList[nowitemNum].SetActive(true);
                    itemget.ItemList[nowitemNum].transform.position = ItemObjPos.transform.position;
                }
            }
        }
        if (itemget.ItemList.Count >= 1)
        {
            if (Input.GetKey(KeyCode.X))
            {
                Raycastmove.MoveStop = true;
                ItemUseMode = true;
                ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    itemget.ItemList[nowitemNum].transform.position = hit.point;
                }
            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                ItemUseMode = false;
                Raycastmove.MoveStop = false;
                 itemget.ItemList[nowitemNum].transform.position = ItemObjPos.transform.position;
            }
        }

    }
}
