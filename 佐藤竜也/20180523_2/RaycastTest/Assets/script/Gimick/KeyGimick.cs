using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGimick : MonoBehaviour {
    [SerializeField]
    GameObject key;
    [SerializeField]
    Itemuse ItemUse;
    [SerializeField]
    ItemGet itemget;
    private void OnCollisionStay(Collision col)
    {
        if (ItemUse == true)
        {
            if (Input.GetMouseButton(0))
            {
                if (col.gameObject.name == "KeyItem")
                {
                    Debug.Log("");
                    Destroy(gameObject);
                    col.gameObject.SetActive(false);
                }
            }
        }
    }
}
