using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionnableDistScript : MonoBehaviour {

    public gere_bras gere_bras;
	public GameObject cube;
    public ChangeColor changcolor;
    public float distance;
    public bool selectable=false;
	// Use this for initialization
	void Start () {
		//cube = new GameObject[transform.childCount];
			//for(int i =  0; i < transform.childCount; i++)
			//{
				//cube[i] = transform.GetChild(i).gameObject;	
			//}
      cube = GameObject.Find("SelectableList/cube/GameObject");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (gere_bras.Opince.transform.position, cube.transform.position);

		if (distance < 0.1) {
			changcolor.changeColor (Color.yellow);
			selectable = true;
		} else {
			changcolor.changeColor (Color.gray);
			selectable = false;
		}
	}

}