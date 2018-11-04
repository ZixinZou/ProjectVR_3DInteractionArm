using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BougeBaseMobile : MonoBehaviour {

    // Use this for initialization
    public NavigationScript navigationScript;
    public gere_bras gere_bras;
    public Vector3 move = new Vector3(0,0,0);
    public Vector3 rotate = new Vector3(0, 0, 0);
    public Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        move = new Vector3(navigationScript.increment_VR.x, 0, 0);
        rotate= new Vector3(0, -navigationScript.increment_VR.z, 0);
        transform.Translate(move * Time.deltaTime*100, Space.Self);
        transform.Rotate(rotate * Time.deltaTime*2000, Space.Self);
    }
}
