using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastMove : MonoBehaviour {
   // private UnityEngine.AI.NavMeshAgent agent;

    //Rayの作成
    private RaycastHit hit;
    private Ray ray;
    //動きとめる用のbool
    public  bool MoveStop  = false;
    //移動地点のマーカー
    [SerializeField]
    GameObject marker;
    [SerializeField]
    ItemGet itemget;

	void Start ()
    {        
        //agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

	void Update ()
    {

        if (MoveStop == false) {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //Rayの可視化(SceneViewのみ)
            //Debug.DrawRay(ray.origin, ray.direction, Color.red);
            if (Physics.Raycast(ray, out hit)
                && hit.collider.tag == "floor")
            {
                marker.transform.position = hit.point;
                //移動
                if (Input.GetMouseButtonDown(0))
                {
                    {
                        //Rayの先の当たった床に移動
                        //agent.SetDestination(hit.point);
                        gameObject.transform.position = hit.point;
                    }
                    transform.position = hit.point;
                }
            }
        }

    }
}