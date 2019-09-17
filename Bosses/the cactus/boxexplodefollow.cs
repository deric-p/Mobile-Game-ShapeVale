using UnityEngine;
using System.Collections;

public class boxexplodefollow : MonoBehaviour {

	public GameObject block;

	// Use this for initialization
	void Start () {
		
		transform.position = new Vector3(block.transform.position.x,block.transform.position.y,transform.position.z);
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3(block.transform.position.x,block.transform.position.y,transform.position.z);
	
	}
}
