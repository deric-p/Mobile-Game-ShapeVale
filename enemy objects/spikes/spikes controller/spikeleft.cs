using UnityEngine;
using System.Collections;

public class spikeleft : MonoBehaviour {

	public float increment;
	public float startingposition;
	public float endingposition;

	// Use this for initialization
	void Start () {

		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	if(Time.timeScale != 0){
			transform.position = new Vector3(transform.position.x+increment,transform.position.y,transform.position.z);
	if(transform.position.x>=endingposition){
		transform.position = new Vector3(startingposition,transform.position.y,transform.position.z);
	}

	}

	
	
	}
}
