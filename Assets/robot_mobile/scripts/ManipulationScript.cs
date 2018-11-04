using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManipulationScript : MonoBehaviour {
    public MaterielScript materielScript;
    public bool manipulate;
    public bool zone_has_cube;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        manipulate = materielScript.B3;
	}
}
