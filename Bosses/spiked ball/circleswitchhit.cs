using UnityEngine;
using System.Collections;

public class circleswitchhit : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D coll){

		if(coll.gameObject.tag == "switch1"){
			
			spikedball.switcher1();
		}
		if(coll.gameObject.tag == "switch2"){
			
			spikedball.switcher2();
		}
		if(coll.gameObject.tag == "switch3"){
			
			spikedball.switcher3();
		}
		if(coll.gameObject.tag == "switch4"){
			
			spikedball.switcher4();
		}
	}
}
