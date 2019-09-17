using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	public GameObject target;
	private Vector2 velocity;
	public float smoothTimeY;
	public float smoothTimeX;
	private bool bounds;
	public Vector3 minCameraPos;
	public Vector3 maxCameraPos;
	private bool complete;

	



	void Start(){
		target = GameObject.FindGameObjectWithTag("circle").gameObject;
		complete = false;
		
		bounds = true;
		smoothTimeY = 4f;
		smoothTimeX = 4f;
		
	}

	public void FixedUpdate(){

		if((transform.position.x == 0)&&
			(transform.position.y == 0)&&
			(!complete)){
			complete = true;
			smoothTimeX = 1f;
			smoothTimeY = 1f;
		}

		float posX = Mathf.SmoothDamp(transform.position.x,target.transform.position.x,ref velocity.x,smoothTimeX);
		float posY = Mathf.SmoothDamp(transform.position.y,target.transform.position.y,ref velocity.y,smoothTimeY);
		
	
		transform.position = new Vector3(posX,posY,transform.position.z);	
		

		if(bounds){

			transform.position = new Vector3 (Mathf.Clamp(transform.position.x,minCameraPos.x,maxCameraPos.x),	
			Mathf.Clamp(transform.position.y,minCameraPos.y,maxCameraPos.y),
				Mathf.Clamp(transform.position.z,minCameraPos.z,maxCameraPos.z));

		}

	}

}
