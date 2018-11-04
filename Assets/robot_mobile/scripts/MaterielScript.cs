using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterielScript : MonoBehaviour
{

   // private Vector3 increment;
   // private bool b1, b2, b3;
    public ClavierScript clavierScript;
    public SourisScript sourisScript;
    public Vector3 increment_IR;
    public bool B1, B2, B3;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        increment_IR = clavierScript.increment;
        B1 = sourisScript.b1;
        B2 = sourisScript.b2;
        B3 = sourisScript.b3;
    }
}
