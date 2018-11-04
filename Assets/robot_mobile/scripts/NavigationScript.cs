using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour {

    public MaterielScript materielScript;
    public Vector3 increment_IR;
    public Vector3 increment_VR;
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(materielScript.B1 == true)
        {

               // Debug.Log("Mode Navigation");


            increment_IR = materielScript.increment_IR;
            increment_VR = increment_IR;
        }
		
	}
}
