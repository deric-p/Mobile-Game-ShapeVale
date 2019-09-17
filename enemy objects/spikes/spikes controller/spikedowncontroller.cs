using UnityEngine;
using System.Collections;

public class spikedowncontroller : MonoBehaviour {

public float increment;
	public float startingposition;
	public float endingposition;

	// Use this for initialization
	void Start () {

		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	if(Time.timeScale != 0){
			transform.position = new Vector3(transform.position.x,transform.position.y-increment,transform.position.z);
	if(transform.position.y<=endingposition){
		transform.position = new Vector3(transform.position.x,startingposition,transform.position.z);
	}

	}

	
	
	}
}
