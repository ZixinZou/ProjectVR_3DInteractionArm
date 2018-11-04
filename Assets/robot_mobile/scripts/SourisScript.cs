using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourisScript : MonoBehaviour {

    // Use this for initialization
	public bool b1 = true, b2 = false, b3=false;


	void Start () {
		
	}

	public void ChangeMod()
	{
		if (b1 == false && b2 == true) {
			b1 = true;
			b2 = false;
		} else if (b2 == false && b1 == true) {
			b1 = false;
			b2 = true;

		}
	}
	public void Catch(){
		b3 = !(b3&true);
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftShift))
        {
			ChangeMod();
        }
      
		if (Input.GetKeyDown(KeyCode.Space))
        {
			Catch();
        }
    }

}
