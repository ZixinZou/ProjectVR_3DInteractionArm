using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TEXT : MonoBehaviour {
	public Text text1;
	public Text text2;
	public SourisScript souris;

	void Start () {

	}


	void Update () {
		if (souris.b1 == true) {
			text1.text = "drive model";
		} 

		else if (souris.b2 == true) {
			text1.text = "select model";
		}

		if (souris.b3 == true) {
			text2.text="On";
		}else
		{
			text2.text="Off";
		}
	}
}
