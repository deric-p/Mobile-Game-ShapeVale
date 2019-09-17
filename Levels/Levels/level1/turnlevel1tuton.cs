using UnityEngine;
using System.Collections;

public class turnlevel1tuton : MonoBehaviour {

	private GameObject screens;
	private GameObject tutorial;
	private GameObject maincam;
	bool complete;

	// Use this for initialization
	void Start () {

	screens = GameObject.FindGameObjectWithTag("screens").gameObject;;
	maincam = GameObject.FindGameObjectWithTag("MainCamera").gameObject;

	complete = false;
	AssignScreens(screens);
	
	}
	void AssignScreens(GameObject screen){

		Transform [] screenchildren = screen.GetComponentsInChildren<Transform> (true);

		for(int i=0;i<screenchildren.Length;i++){

			if(screenchildren[i].gameObject.tag == "tutorial"){

			tutorial = screenchildren[i].gameObject;

			}

		}
	}
	
	// Update is called once per frame
	void Update () {

	if((maincam.transform.position.x == 0)&&
		(maincam.transform.position.y==0)&&
		(!complete)){
		tutorial.SetActive(true);
		complete = true;
	}


	
	}
}
