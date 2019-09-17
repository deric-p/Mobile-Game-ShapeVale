using UnityEngine;
using System.Collections;

public class rightwallspikes : MonoBehaviour {

	private float wall_positionx = 4.8f;
	

	// Use this for initialization
	void Start () {
	

	Vector3 wall_position = transform.localPosition;
	wall_position.x = (Camera.main.aspect)*(wall_positionx);
	transform.localPosition = wall_position;

	

	}
	
	// Update is called once per frame
	void Update () {

	Vector3 wall_position = transform.localPosition;
	wall_position.x = (Camera.main.aspect)*(wall_positionx);
	transform.localPosition = wall_position;
	
	}
}
