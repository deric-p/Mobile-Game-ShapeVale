using UnityEngine;
using System.Collections;

public class spikeup : MonoBehaviour {

	private float increment;

	// Use this for initialization
	void Start () {

	increment = 0.15f;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	if(Time.timeScale !=0f){

		transform.position = new Vector3(transform.position.x,transform.position.y+increment,transform.position.z);
	if(transform.position.y>=5){
		transform.position = new Vector3(transform.position.x,-4.8f,transform.position.z);
	}

	}

	
	
	}
}
