using UnityEngine;
using System.Collections;

public class circle_collisions : MonoBehaviour {


	
	private GameObject circle;
	private GameObject explode_circle;
	private GameObject explode;
	private Animator animatorcircle;
	private int circlecolor;
	private GameObject screens;
	private GameObject victory;
	private bool complete;
	private GameObject [] darkspots;


	// Use this for initialization
	void Start() {

	circlecolor = 0;
	explode = GameObject.FindGameObjectWithTag("explode_tags").gameObject;	
	screens = GameObject.FindGameObjectWithTag("screens").gameObject;

	complete = false;

	AssignVictory(screens);
	
	}
	void Awake(){
		circle = GameObject.FindGameObjectWithTag("circle").gameObject;	
		animatorcircle = circle.GetComponent<Animator>();

	}

	void AssignVictory(GameObject screen){

		Transform [] screenchildren = screen.GetComponentsInChildren<Transform> (true);

		for(int i=0;i<screenchildren.Length;i++){

			if(screenchildren[i].gameObject.tag == "victory"){

			victory = screenchildren[i].gameObject;

			}

		}
	}

	void explodecircle(GameObject circle){

	circlecolor = animatorcircle.GetInteger("switch");
	
	Transform [] circlechildren = circle.GetComponentsInChildren<Transform> (true);

	for(int i=0;i<circlechildren.Length;i++){

		if((circlechildren[i].gameObject.tag == "explode_white")&&
			(circlecolor == 0)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_green")&&
			(circlecolor == 1)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_teal")&&
			(circlecolor == 2)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_black")&&
			(circlecolor == 3)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_blue")&&
			(circlecolor == 4)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_yellow")&&
			(circlecolor == 5)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_orange")&&
			(circlecolor == 6)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_purple")&&
			(circlecolor == 7)){

			explode_circle = circlechildren[i].gameObject;
		}
		if((circlechildren[i].gameObject.tag == "explode_red")&&
			(circlecolor == 8)){

			explode_circle = circlechildren[i].gameObject;
		}


	}

	}

	IEnumerator setVictory(){

		yield return new WaitForSeconds(0.5f);

		victory.SetActive(true);

	}
	
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D enemy) {

       explodecircle(explode);

       if((enemy.gameObject.tag == "spike")||
       	(enemy.gameObject.tag == "enemy_objects")||
       	(enemy.gameObject.tag == "boss")){
       	
       	circle.SetActive(false);
       	explode_circle.SetActive(true);
       }
       if((enemy.gameObject.tag == "levelcomplete")&&
       	(!complete)){
       	complete = true;
       	StartCoroutine("setVictory");
       }
        
    }
    void OnTriggerEnter2D(Collider2D other){

    	if(other.gameObject.tag == "whitespots"){
    		darkspots = GameObject.FindGameObjectsWithTag("darkspots");	
    		for(int i=0;i<darkspots.Length;i++){
    			darkspots[i].GetComponent<PolygonCollider2D>().enabled = false;
    		}
    	}
    	if(other.gameObject.tag == "darkspots"){
    		circle.SetActive(false);
       		explode_circle.SetActive(true);
    	}

    }
    void OnTriggerExit2D(Collider2D other){

    	if(other.gameObject.tag == "whitespots"){
    		darkspots = GameObject.FindGameObjectsWithTag("darkspots");	
    		for(int i=0;i<darkspots.Length;i++){
    			darkspots[i].GetComponent<PolygonCollider2D>().enabled = true;
    		}
    	}
    	if(other.gameObject.tag == "darkspots"){
    		circle.SetActive(false);
       		explode_circle.SetActive(true);
    	}

    }
    
}