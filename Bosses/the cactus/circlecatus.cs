using UnityEngine;
using System.Collections;

public class circlecatus : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag == "switch"){
			cactus.CheckPlatform(other.gameObject);
		}
		if(other.gameObject.tag == "switch1"){
			cactus.CheckSwitch(other.gameObject);
		}
		if(other.gameObject.tag == "whitepickup"){
			cactus.Checkspots(other.gameObject);
		}
	}
}
