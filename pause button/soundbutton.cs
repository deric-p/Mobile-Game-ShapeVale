using UnityEngine;
using System.Collections;

public class soundbutton : MonoBehaviour {

	private float button_positionx = 3f;
	private GameObject maincam;
	private GameObject tempbox;
	private GameObject soundbuttons;

	// Use this for initialization
	void Start () {
	soundbuttons = GameObject.FindGameObjectWithTag("sound").gameObject;
	if(sound.instance.efxMusic.mute == true){
		soundbuttons.GetComponent<Animator>().SetBool("mute",true);
	}
	else{
		soundbuttons.GetComponent<Animator>().SetBool("mute",false);
	}
	maincam = GameObject.FindGameObjectWithTag("MainCamera").gameObject;
	
	tempbox = null;

	}
	GameObject checkTouch(Vector3 pos){

    	Vector3 wp = Camera.main.ScreenToWorldPoint(pos);
		Vector2 touchPos = new Vector2 (wp.x, wp.y);
    	Collider2D hit = Physics2D.OverlapPoint(touchPos);

    	if(hit){
    		
    		return hit.transform.gameObject;
         	
    	}
    	else{

    		return null;
    	}
    }
	
	// Update is called once per frame
	void Update () {

	Vector3 button_position = transform.localPosition;
	button_position.x = (Camera.main.aspect)*(button_positionx);
	transform.localPosition = button_position;

	transform.position = new Vector3((maincam.transform.position.x+transform.position.x),maincam.transform.position.y+4.2f,transform.position.z);
	if(Input.touchCount > 0){

            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                //temp box
                 tempbox = checkTouch(Input.GetTouch(0).position);
                 
            }
        }
    if(tempbox == soundbuttons){
    	tempbox = null;
    	if(soundbuttons.GetComponent<Animator>().GetBool("mute")){
    		soundbuttons.GetComponent<Animator>().SetBool("mute",false);
    		sound.instance.efxMusic.mute = false;
    		sound.instance.efxSource.mute = false;
    	}
    	else{
    		soundbuttons.GetComponent<Animator>().SetBool("mute",true);
    		sound.instance.efxMusic.mute = true;
    		sound.instance.efxSource.mute = true;
    	}
	

    }
	
	}
}