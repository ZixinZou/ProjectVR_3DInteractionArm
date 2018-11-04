using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendObject : MonoBehaviour {
    public gere_bras gere_bras;
    public ManipulationScript manipulation_script;
    public GameObject Opinge_d;
    public GameObject Opinge_g;
    public GameObject pince;
    public GameObject cube;
    public GameObject rigid_cube;
    public Transform old_parent;
    public SelectionnableDistScript selectable;

    // Use this for initialization
    void Start () {
        old_parent = cube.transform.parent;

    }
	
	// Update is called once per frame
	void Update () {
        
		if(manipulation_script.manipulate==true)
        {
            Opinge_d.transform.localPosition = new Vector3(0.017F, 0F, 0F);
            Opinge_g.transform.localPosition = new Vector3(-0.017F, 0F, 0F);

            if (selectable.selectable == true) {

                
                cube.transform.parent = pince.transform;
               
                rigid_cube.GetComponent<Rigidbody>().isKinematic = true;
            }

        }
        else
        {
            Opinge_d.transform.localPosition = new Vector3(0.034F, 0F, 0F);
            Opinge_g.transform.localPosition = new Vector3(-0.034F, 0F, 0F);

            cube.transform.parent = old_parent;
            rigid_cube.GetComponent<Rigidbody>().isKinematic = false;
        }

	}
}
