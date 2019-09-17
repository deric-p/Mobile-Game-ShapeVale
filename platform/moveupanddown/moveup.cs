using UnityEngine;
using System.Collections;

public class moveup : MonoBehaviour {

	public Vector3 endingpoint;
	public Vector3 startingpoint;
	public float speedy;
	private bool moveforward;
	private bool movebackwards;

	// Use this for initialization
	void Start () {

		moveforward = false;
		movebackwards = false;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if(transform.position.y <= startingpoint.y){

			moveforward  = true;
			movebackwards = false;
		}
		if(transform.position.y >= endingpoint.y){
			movebackwards = true;
			moveforward = false;
		}
		if(movebackwards == true){
			transform.position = new Vector3(transform.position.x,transform.position.y-speedy,transform.position.z);
		}
		if(moveforward == true){
			transform.position = new Vector3(transform.position.x,transform.position.y+speedy,transform.position.z);
		}
	
	}
}
