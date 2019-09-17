using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelcheckpoint : MonoBehaviour {
	private GameObject screens;
	private GameObject defeat;
	private GameObject victory;
	private GameObject pause;
	private GameObject pauseButton;
	private GameObject explode;
	private GameObject explode_circle;
	private GameObject circle;
	private Animator circleswitch;
	private GameObject tempbox;
	private int circlecolor;
	private GameObject [] turnoffonloading;
	private GameObject [] platforms;
	private GameObject [] spikes;
	public GUIText loading;
	public GUIText stage;
	private int loadprogress = 0;
	public string nextlevel;
	public string mainmenu;
	private bool complete;
	private string stagetext;
	public Vector3 circleoriginalposition;
	private GameObject tutorial;
	public string currentlevel;
	private GameObject soundbutton;
	private bool checkpoint;
	public Vector3 checkpointreset;	


	// Use this for initialization
	void Start () {



	screens = GameObject.FindGameObjectWithTag("screens").gameObject;
	AssignScreens(screens);
	
	pauseButton = GameObject.FindGameObjectWithTag("pausebutton").gameObject;
	soundbutton = GameObject.FindGameObjectWithTag("sound").gameObject;
	tempbox = null;
	complete = false;
	turnoffonloading = GameObject.FindGameObjectsWithTag("turnoff");
	stage.fontSize = (Screen.width)/27;
	stagetext = stage.text;
	checkpoint = false;

	
	}
	void Awake(){
		circle = GameObject.FindGameObjectWithTag("circle").gameObject;	
		explode = GameObject.FindGameObjectWithTag("explode_tags").gameObject;
		circleswitch = circle.GetComponent<Animator>();
		checkexplodedcircle(explode);
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

    void checkexplodedcircle(GameObject circles){

    if(circle.activeSelf == true){

    	circlecolor = circleswitch.GetInteger("switch");

    }
	
	Transform [] circlechildren = circles.GetComponentsInChildren<Transform> (true);

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

	// Update is called once per frame
	void Update () {
		if((circle.transform.position.x>=checkpointreset.x)&&
			(circle.transform.position.y>=checkpointreset.y)&&
			(!checkpoint)){
			checkpoint = true;
			circleoriginalposition.x = checkpointreset.x;
			circleoriginalposition.y = checkpointreset.y;
			circleoriginalposition.z = checkpointreset.z;
		}


		if(circle.activeSelf==true){
			checkexplodedcircle(explode);
		}

		
		if(Input.touchCount > 0){

            if(Input.GetTouch(0).phase == TouchPhase.Ended){
                //temp box
                 tempbox = checkTouch(Input.GetTouch(0).position);
                 
            }
        }
        if((tutorial.activeSelf == true)&&
        	(!complete)){
        	
        	complete = true;
        	pauseButton.SetActive(false);
        	soundbutton.GetComponent<Animator>().SetBool("off",true);
        	spikes = GameObject.FindGameObjectsWithTag("spike");
			platforms = GameObject.FindGameObjectsWithTag("platform");
        	

        }

	   	if(tempbox == pauseButton){
	   		tempbox = null;
	   		Time.timeScale = 0f;
	   		pause.SetActive(true);
	   		pauseButton.SetActive(false);
	   		soundbutton.GetComponent<Animator>().SetBool("off",true);
	   		sound.instance.efxMusic.Stop();
	   		stage.text = "";
	   		spikes = GameObject.FindGameObjectsWithTag("spike");
			platforms = GameObject.FindGameObjectsWithTag("platform");
	   		for(int i=0;i<spikes.Length;i++){
        		spikes[i].GetComponent<Collider2D>().enabled = false;
        		
        	}
        	for(int i=0;i<platforms.Length;i++){

        		platforms[i].GetComponent<Collider2D>().enabled = false;
        		
        	}
	   	}

	   	if((victory.activeSelf == true)&&
	   		(!complete)){
	   		Time.timeScale = 0f;
	   		sound.instance.efxMusic.Stop();
	   		sound.instance.victorious();
	   		pauseButton.SetActive(false);
	   		soundbutton.GetComponent<Animator>().SetBool("off",true);
	   		complete = true;
	   		stage.text = "";
	   		if(PlayerPrefs.GetInt(currentlevel)!=1){

            PlayerPrefs.SetInt(currentlevel, 1);
        	}
	   		spikes = GameObject.FindGameObjectsWithTag("spike");
			platforms = GameObject.FindGameObjectsWithTag("platform");
	   		for(int i=0;i<spikes.Length;i++){
        		spikes[i].GetComponent<Collider2D>().enabled = false;
        		
        	}
        	for(int i=0;i<platforms.Length;i++){
        		platforms[i].GetComponent<Collider2D>().enabled = false;
        		        	}
	   	}

	   	if((explode_circle.activeSelf == true)&&
	   		(!complete)){
	   		
	   		sound.instance.balldie();
	   		tempbox = null;
	   		complete = true;
	   		StartCoroutine("delayedDefeat");
	   	}

	   	if((victory.activeSelf == true)||
	   		(defeat.activeSelf == true)||
	   		(pause.activeSelf==true)||
	   		(tutorial.activeSelf==true)){

	   		if(tempbox == tutorial){
	   			tutorial.SetActive(false);
	   			soundbutton.GetComponent<Animator>().SetBool("off",false);
	   			sound.instance.buttonclick();
	   			complete = false;
	   			Time.timeScale = 1f;
	   			pauseButton.SetActive(true);
	   		}

	   		if(tempbox == screens){
	   			tempbox = null;
	   			
	   			StartCoroutine(loadinglevel(mainmenu));
	   			sound.instance.buttonclick();
			   	for(int i=0;i<spikes.Length;i++){
	        		spikes[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	        	for(int i=0;i<platforms.Length;i++){
	        		platforms[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	   		}
	   		if(tempbox == victory){
	   			tempbox = null;
	   			complete = false;
	   			sound.instance.buttonclick();
	   			StartCoroutine(loadinglevel(nextlevel));
	   			for(int i=0;i<spikes.Length;i++){
	        		spikes[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	        	for(int i=0;i<platforms.Length;i++){
	        		platforms[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	   		}
	   		if(tempbox == pause){
	   			tempbox = null;
	   			Time.timeScale =1f;
	   			complete = false;
	   			pause.SetActive(false);
	   			pauseButton.SetActive(true);
	   			soundbutton.GetComponent<Animator>().SetBool("off",false);
	   			sound.instance.efxMusic.Play();
	   			sound.instance.buttonclick();
	   			stage.text = stagetext;
	   			for(int i=0;i<spikes.Length;i++){
	        		spikes[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	        	for(int i=0;i<platforms.Length;i++){
	        		platforms[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	   			
	   		}
	   		if(tempbox == defeat){
	   			tempbox = null;
	   			Time.timeScale =1f;
	   			complete = false;
	   			defeat.SetActive(false);
	   			pauseButton.SetActive(true);
	   			explode_circle.SetActive(false);
	   			soundbutton.GetComponent<Animator>().SetBool("off",false);
	   			sound.instance.efxMusic.Play();
	   			sound.instance.buttonclick();
	   			circle.transform.position = new Vector3(circleoriginalposition.x,circleoriginalposition.y,circleoriginalposition.z);
	   			circle.SetActive(true);
	   			stage.text = stagetext;
	   			for(int i=0;i<spikes.Length;i++){
	        		spikes[i].GetComponent<Collider2D>().enabled = true;
	        		
	        	}
	        	for(int i=0;i<platforms.Length;i++){
	        		platforms[i].GetComponent<Collider2D>().enabled = true;
	        
	        	}
	   			
	   		}

	   	}
   		
	
	}
	 IEnumerator loadinglevel(string level){

        Time.timeScale = 1f;
        victory.SetActive(false);
        defeat.SetActive(false);
        pause.SetActive(false);
        stage.text = "";
        circle.SetActive(false);
       	
       	for(int i=0;i<turnoffonloading.Length;i++){
       		turnoffonloading[i].SetActive(false);
       	}
        
        loading.fontSize = (Screen.width)/19;
        loading.text = "Loading "+ loadprogress +"%";
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while(!async.isDone){
            loadprogress = (int)(async.progress * 100);
            loading.text = "Loading "+ loadprogress +"%";
           yield return null;
        }
        

      }
     IEnumerator delayedDefeat(){
     	yield return new WaitForSeconds(0.5f);
     	soundbutton.GetComponent<Animator>().SetBool("off",true);
	   	sound.instance.efxMusic.Stop();
	   	sound.instance.defeated();
     	defeat.SetActive(true);
     	pauseButton.SetActive(false);
     	Time.timeScale = 0f;
     	stage.text = "";
     	spikes = GameObject.FindGameObjectsWithTag("spike");
		platforms = GameObject.FindGameObjectsWithTag("platform");
     	for(int i=0;i<spikes.Length;i++){
        		spikes[i].GetComponent<Collider2D>().enabled = false;
        		
        	}
        	for(int i=0;i<platforms.Length;i++){
        		platforms[i].GetComponent<Collider2D>().enabled = false;
        		
        	}

     }   
   
}