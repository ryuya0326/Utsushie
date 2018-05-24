using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class EyeAnchorsTest : MonoBehaviour {

    GameObject[] eyes = new GameObject[2];
    string[] eyeAnchorNames = { "LeftEyeAnchor", "RightEyeAnchor" };

	void Start ()
    {
	    	
	}

	void Update ()
    {
		for(int i = 0; i < 2; ++i)
        {
            if(eyes[i] != null && eyes[i].transform.parent != transform)
            {
                eyes[i] = null;
            }

            if(eyes[i] == null)
            {
                Transform t = transform.Find(eyeAnchorNames[i]);
                if (t)
                    eyes[i] = t.gameObject;

                if(eyes[i] == null)
                {
                    eyes[i] = new GameObject(eyeAnchorNames[i]);
                    eyes[i].transform.parent = gameObject.transform;
                }
            }
            //eyes[i].transform.localPosition = UnityEngine.XR.InputTracking.GetLocalPosition((UnityEngine.XR.XRNode)i);
            //eyes[i].transform.localRotation = UnityEngine.XR.InputTracking.GetLocalRotation((UnityEngine.XR.XRNode)i);
        }
	}
}
