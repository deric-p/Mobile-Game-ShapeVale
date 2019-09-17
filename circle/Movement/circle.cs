using UnityEngine;
using System.Collections;

public class circle : MonoBehaviour {

	public float movespeed;
	public float jumpheight;
	private Rigidbody2D rb;
	private Vector2 touchOrigin = - Vector2.one;
	private Vector2 myPosition;
	private Vector3 touchpos;
	private int zaxis;
	private Camera maincamera;
	private GameObject findingcamera;
	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatisground;
	private bool grounded;
	private float xdirection;
	private bool moving;
	private GameObject victory;
	private GameObject defeat;
	private GameObject pause;
	private GameObject screens;
	private GameObject pausebutton;
	private GameObject tempbox;
	private int timer;
	private GameObject tutorial;
	private bool caminposition;
	private int count;
	private Vector3 forcejump;
	private Vector2 forcingjump;
	private GameObject soundbutton;


	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D>();
		zaxis = -8;
		findingcamera = GameObject.FindGameObjectWithTag("MainCamera").gameObject;
		maincamera = findingcamera.GetComponent<Camera>();
		moving = false;
		screens = GameObject.FindGameObjectWithTag("screens").gameObject;
		AssignScreens(screens);
		pausebutton = GameObject.FindGameObjectWithTag("pausebutton").gameObject;
		soundbutton = GameObject.FindGameObjectWithTag("sound").gameObject;
		tempbox = null;
		timer = 0;
		caminposition = false;
		count = 0;
		
	}
	void AssignScreens(GameObject screen){

		Transform [] screenchildren = screen.GetComponentsInChildren<Transform> (true);

		for(int i=0;i<screenchildren.Length;i++){

			if(screenchildren[i].gameObject.tag == "victory"){

			victory = screenchildren[i].gameObject;

			}
			if(screenchildren[i].gameObject.tag == "defeat"){

			defeat = screenchildren[i].gameObject;

			}
			if(screenchildren[i].gameObject.tag == "pause"){

			pause = screenchildren[i].gameObject;

			}
			if(screenchildren[i].gameObject.tag == "tutorial"){

			tutorial = screenchildren[i].gameObject;

			}

		}
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

	void FixedUpdate(){

		grounded = Physics2D.OverlapCircle(groundCheck.position,groundCheckRadius,whatisground);
		xdirection = Input.acceleration.x;

		
	}

	void ForceJump(Vector3 touchposition,Vector2 t){

		float difference = ((t.x) - (touchposition.x));
		float differencey = ((t.y) - (touchposition.y));

		float deltax = Mathf.Abs(difference);
		float deltay = Mathf.Abs(differencey);


		if(((deltax <=1)&&(deltay <=0.8)) &&
			(touchposition.x > t.x)) {

			rb.velocity = new Vector2(movespeed,rb.velocity.y);
			count =0;

		}

		if(((deltax <=1)&&(deltay <=0.8))&&
			(touchposition.x < t.x)){

			rb.velocity = new Vector2(-movespeed,rb.velocity.y);
			count =0;

		}
		
		if(((deltax >1)||(deltay >0.8))&&
			(touchposition.x > t.x)){

			rb.velocity = new Vector2(movespeed*2,jumpheight);
			count =0;

		}
			
		if(((deltax >1)||(deltay >0.8))&&
			(touchposition.x < t.x)){

			rb.velocity = new Vector2(-movespeed*2,jumpheight);
			count =0;

		}

	}

	void MoveTheBall(Vector3 touchposition, Vector2 t){

		float difference = ((t.x) - (touchposition.x));
		float differencey = ((t.y) - (touchposition.y));

		float deltax = Mathf.Abs(difference);
		float deltay = Mathf.Abs(differencey);


		if(grounded){

			if(((deltax <=1)&&(deltay <=0.8)) &&
				(touchposition.x > t.x)) {

				rb.velocity = new Vector2(movespeed,rb.velocity.y);
				count =0;

			}
			if(((deltax <=1)&&(deltay <=0.8))&&
				(touchposition.x < t.x)){

				rb.velocity = new Vector2(-movespeed,rb.velocity.y);
				count =0;

			}
			if(((deltax >1)||(deltay >0.8))&&
				(touchposition.x > t.x)){

				rb.velocity = new Vector2(movespeed*2,jumpheight);
				count =0;

			}
			if(((deltax >1)||(deltay >0.8))&&
				(touchposition.x < t.x)){

				rb.velocity = new Vector2(-movespeed*2,jumpheight);
				count =0;

			}


		}

		if(count ==1){
				
			forcejump = touchposition;
			forcingjump = t;
			count = 2;
				
		}
	
		
	}

	IEnumerator MoveBallMotionleft(){

		
		moving = true;
		yield return new WaitForSeconds(0.06f);
		
		moving = false;

	}
	IEnumerator MoveBallMotionright(){

		
		moving = true;
		yield return new WaitForSeconds(0.06f);
		
		moving = false;

	}
	IEnumerator timercheck(){
		yield return new WaitForSeconds(1);
		timer++;
		
	}
	
	// Update is called once per frame
	void Update () {

	if((defeat.activeSelf)&&
		(caminposition)){
		caminposition = false;
	}
	

	if((count==2)&&
	(grounded)){
		
		ForceJump(forcejump,forcingjump);
	}

	if((findingcamera.transform.position.x == 0)&&
		(findingcamera.transform.position.y == 0)&&
		(caminposition != true)){
		caminposition = true;
	}

		myPosition = transform.position;
		
		if((victory.activeSelf != true)&&
			(defeat.activeSelf != true)&&
			(pause.activeSelf != true)&&
			(tutorial.activeSelf !=true)&&
			(caminposition == true)){


			if(Input.touchCount > 0){

			Touch myTouch = Input.touches[0];

			if(myTouch.phase == TouchPhase.Began){

				tempbox = checkTouch(Input.GetTouch(0).position);
				
				
			}
			else if (myTouch.phase  == TouchPhase.Ended && touchOrigin.x >= 0){

				if((tempbox != pausebutton)&&
					(tempbox !=victory)&&
					(tempbox !=defeat)&&
					(tempbox !=pause)&&
					(tempbox !=soundbutton)){

					touchOrigin = myTouch.position;
				}
				
				if((Time.timeScale != 0f)&&
					(tempbox !=pausebutton)&&
					(tempbox !=victory)&&
					(tempbox !=defeat)&&
					(tempbox !=pause)&&
					(tempbox !=soundbutton)){
					touchpos = maincamera.ScreenToWorldPoint(new Vector3(touchOrigin.x,touchOrigin.y,zaxis));
					count = 1;
					MoveTheBall(touchpos,myPosition);
					
				}
				
			}

			}
			if(Input.GetMouseButtonDown(0)){
				touchOrigin = Input.mousePosition;
				
			}
			if((Input.GetMouseButtonUp(0))&& touchOrigin.x >=0){

				
				if((Time.timeScale != 0f)&&
					(tempbox !=pausebutton)&&
					(tempbox !=victory)&&
					(tempbox !=defeat)&&
					(tempbox !=pause)&&
					(tempbox !=soundbutton)){
					
					touchpos = maincamera.ScreenToWorldPoint(new Vector3(touchOrigin.x,touchOrigin.y,zaxis));
					count = 1;
					MoveTheBall(touchpos,myPosition);
					
				}
			}
		
			if((xdirection <= -0.1)&&(!moving)){
				
				
				if(grounded){
					rb.velocity = new Vector2(-movespeed,rb.velocity.y);
				}
				if(!grounded){
					rb.velocity = new Vector2(-movespeed,rb.velocity.y);
				}
				
				StartCoroutine("MoveBallMotionleft");

			}
			if((xdirection >= 0.1)&&(!moving)){
				
				
				if(grounded){
					rb.velocity = new Vector2(movespeed,rb.velocity.y);
				}
				if(!grounded){
					rb.velocity = new Vector2(movespeed,rb.velocity.y);
				}
				StartCoroutine("MoveBallMotionright");

			}

			

		}

		if(moving){


			StartCoroutine("timercheck");
			if(timer >= 5){
				moving = false;
				timer = 0;
			}
		}
		
		
	}
}
