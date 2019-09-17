using UnityEngine;
using System.Collections;

public class fallingobjectsnearcircle : MonoBehaviour {

	public GameObject circle;
	private float x;
	private float y;
	private float z;
	private Rigidbody2D rb;
	public GameObject defeat;

	// Use this for initialization
	void Start () {

		x = transform.position.x;
		y = transform.position.y;
		z = transform.position.z;
		rb = GetComponent<Rigidbody2D>();
		
	
	}
	
	// Update is called once per frame
	void Update () {

		if(circle.transform.position.x >= x-0.01){

			rb.isKinematic = false;

		}

		if(defeat.activeSelf){
			transform.position = new Vector3(x,y,z);
			transform.rotation = Quaternion.Euler(0,0,45);
			rb.isKinematic = true;
		}
	
	}
}
