using UnityEngine;
using System.Collections;


public class ClavierScript : MonoBehaviour {
    public gere_bras bras_robot;
    public const float inc_step = 0.01F;
	// Use this for initialization
	void Start () { 
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        string aux;
        Vector3 new_increment;
        bool key_ok = false;
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            new_increment = new Vector3(0.0F, inc_step, 0.0F);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            new_increment = new Vector3(0.0F, -inc_step, 0.0F);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            new_increment = new Vector3(-inc_step, 0.0F, 0.0F);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            new_increment = new Vector3(inc_step, 0.0F, 0.0F);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            new_increment = new Vector3(0.0F, 0.0F, -inc_step);
        }
        else if (Input.GetKeyUp(KeyCode.Z))
        {
            new_increment = new Vector3(0.0F, 0.0F, inc_step);
        }
        else
        {
            new_increment = new Vector3(0.0F, 0.0F, 0.0F);
            //Debug.Log("Touche incorrecte!");
        }
        if (new_increment.magnitude > 0.0F)
        {
            aux = "increment = [" + new_increment.x.ToString("0.0000") + "," + new_increment.y.ToString("0.0000") + "," + new_increment.z.ToString("0.0000") + "]";
            Debug.Log(aux);
            bras_robot.increment = new_increment;
        }
	}
}
