using UnityEngine;
using System.Collections;
 
public class CubeCollision : MonoBehaviour {
 
	public GameObject Cube;
     // Use this for initialization
     void Start () {

	}
 
     // Update is called once per frame
     void Update () {
     }

     // 碰撞开始
     void OnCollisionEnter(Collision collision) {
		Cube.GetComponent<Renderer> ().material.color = Color.red;
     }
}
