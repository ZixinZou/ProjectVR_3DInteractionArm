using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

	public GameObject game_object;
	private Component[] hingeJoints;
	// Use this for initialization
	void Start () {
		game_object = GameObject.Find("cube");

		changeColor(Color.gray);
	}

	// Update is called once per frame
	void Update () {


	}

	public void changeColor(Color color)
	{

		game_object.GetComponent<Renderer>().material.color=color;

	}
}
