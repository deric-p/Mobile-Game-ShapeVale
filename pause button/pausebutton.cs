using UnityEngine;
using System.Collections;

public class pausebutton : MonoBehaviour {

	private float button_positionx = 4f;
	private GameObject maincam;

	// Use this for initialization
	void Start () {
	
	maincam = GameObject.FindGameObjectWithTag("MainCamera").gameObject;

	}
	
	// Update is called once per frame
	void Update () {

	Vector3 button_position = transform.localPosition;
	button_position.x = (Camera.main.aspect)*(button_positionx);
	transform.localPosition = button_position;

	transform.position = new Vector3((maincam.transform.position.x+transform.position.x),maincam.transform.position.y+4.2f,transform.position.z);
	
	
	}
}
