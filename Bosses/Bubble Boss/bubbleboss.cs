using UnityEngine;
using System.Collections;

public class bubbleboss : MonoBehaviour {

	public GUIText health;
	public GameObject explode;
	public GameObject bubble;
	public GameObject victory;
	private bool complete;
	private GameObject [] spikes;
	private float speedy;
	Vector3 bubble_scale;

	// Use this for initialization
	void Start () {
	sound.instance.boss();
	complete = false;
	speedy = 0.06f;
	bubble_scale = transform.localScale;;
	spikes = GameObject.FindGameObjectsWithTag("spike");
	
	}

	void FixedUpdate(){

		Vector3 bubble_position = transform.localPosition;
		

		if(bubble_position.x <= -5.6){

			
			bubble_scale.x = -0.7f;
	    	transform.localScale = bubble_scale;
			
		}
		if(bubble_position.x >= 5.6){

			
			bubble_scale.x = 0.7f;
	    	transform.localScale = bubble_scale;
			
		}
		if((bubble_scale.x == 0.7f)&&
			(bubble.activeSelf)){
			bubble_position.x = bubble_position.x-speedy;
			bubble_position.z = 0;
			transform.position = bubble_position;
		}
		if((bubble_scale.x == -0.7f)&&
			(bubble.activeSelf)){
			bubble_position.x = bubble_position.x+speedy;
			bubble_position.z = 0;
			transform.position = bubble_position;
		}

	}
	
	// Update is called once per frame
	void Update () {

	if((health.text == "The Dark Bubble: 0%")&&
		(!complete)){
		sound.instance.bubbledie();
		complete = true;
		explode.SetActive(true);
		bubble.SetActive(false);
		victory.SetActive(true);
		for(int i=0;i<spikes.Length;i++){
			spikes[i].SetActive(false);
		}
	}
	
	}
}
