using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionScript : MonoBehaviour {

    public MaterielScript materielScript;
    public Vector3 increment_IR;
    public Vector3 increment_VR;
    public int num_cube;

    
    
    public bool zone_has_cube;
    // Use this for initialization

    public gere_bras gere_bras;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



        if (materielScript.B2 == true)
        {
          //  Debug.Log("Mode Selection");
            increment_IR = materielScript.increment_IR;
            gere_bras.increment = increment_IR;
        }
    }
}
