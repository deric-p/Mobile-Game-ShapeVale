using UnityEngine;
using System.Collections;

public class explode_follow : MonoBehaviour {

	
	private GameObject circle;

	// Use this for initialization
	void Start () {

		circle = GameObject.FindGameObjectWithTag("circle").gameObject;	
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if(circle.activeSelf){
			if(circle.GetComponent<Animator>().GetInteger("switch")!=9){

				transform.position = new Vector3(circle.transform.position.x,circle.transform.position.y,transform.position.z);

			}
		}
		
		
	}
}
