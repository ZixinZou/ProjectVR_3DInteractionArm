using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClavierScript : MonoBehaviour {
	// public gere_bras gere_bras=null;

	public Vector3 increment = new Vector3(0,0,0);
	public float step = 0.01f;

	public Vector3 GetVector3()
	{
		return increment;
	}

	// Use this for initialization
	void Start () {

	}

	public void goLeft(){
		increment.z += step;
	}
	public void goRight(){
		increment.z -= step;
	}
	public void goUp(){
		increment.x += step;
	}
	public void goDown(){
		increment.x -= step;
	}
	public void goHigh(){
		increment.y += step;
	}
	public void goLow(){
		increment.y -= step;
	}

	// Update is called once per frame
	void Update () {


		if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			goLeft ();
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			goRight ();
		}
		if (Input.GetKeyUp(KeyCode.LeftArrow)|| Input.GetKeyUp(KeyCode.RightArrow))
		{
			//Debug.Log("Z ");
			increment.z = 0;
		}



		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			goUp();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			goDown();
		}
		if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
		{
			increment.x = 0;
		}



		if (Input.GetKeyDown(KeyCode.Z))
		{
			goLow();
		}
		if (Input.GetKeyDown(KeyCode.A))
		{

			goHigh();
		}
		if (Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.A))
		{
			increment.y = 0;
		}


	}
}
