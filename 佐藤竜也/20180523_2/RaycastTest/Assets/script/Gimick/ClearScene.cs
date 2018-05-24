using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearScene : MonoBehaviour {
    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag=="Player")
        SceneManager.LoadScene("Clearscene");
    }
}
