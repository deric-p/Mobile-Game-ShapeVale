using UnityEngine;
using System.Collections;

public class watercrash : MonoBehaviour {

	public GameObject block;

	void OnCollisionEnter2D(Collision2D other){

		if(other.gameObject.tag == "boss"){
			fallingwater.returnObject(block);
		}
		if(other.gameObject.tag == "platform"){
			fallingwater.returnplatform(block);
		}
	}

}
