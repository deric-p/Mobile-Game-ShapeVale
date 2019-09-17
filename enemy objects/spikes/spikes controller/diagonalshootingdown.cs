using UnityEngine;
using System.Collections;

public class diagonalshootingdown : MonoBehaviour {
	public float xincrement;
	public float yincrement;
	public Vector3 startingposition;
	public Vector3 endingposition;

	// Use this for initialization
	void Start () {

		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	if(Time.timeScale != 0){
			transform.position = new Vector3(transform.position.x+xincrement,transform.position.y-yincrement,transform.position.z);
	if(transform.position.y<=endingposition.y){
		transform.position = new Vector3(startingposition.x,startingposition.y,transform.position.z);
	}

	}

	
	
	}
}
