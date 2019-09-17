using UnityEngine;
using System.Collections;

public class knockover : MonoBehaviour {

	private bool defeated;
	public GameObject defeat;
	private Vector3 barposition;

	// Use this for initialization
	void Start () {

		defeated = false;
		barposition = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		if((defeat.activeSelf)&&
			(!defeated)){
			defeated = true;
		}
		if((!defeat.activeSelf)&&
			(defeated)){
			transform.position = new Vector3(barposition.x,barposition.y,barposition.z);
			transform.rotation = Quaternion.identity;
		}
	
	}
}
