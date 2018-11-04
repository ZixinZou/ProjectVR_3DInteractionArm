using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCamera : MonoBehaviour {

	public SourisScript souris;
	public Camera cams1;
    public Camera cams2;
    void Start()
	{
		cams1.enabled = false;
        cams2.enabled = true;
    }

	void Update()
	{

        if (souris.b1 == true) {
            cams1.enabled = true;
            cams2.enabled = false;

        } else {
            cams1.enabled = false;
            cams2.enabled = true;

        }
    }

}
