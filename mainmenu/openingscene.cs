using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class openingscene : MonoBehaviour {

	public GUIText start;
	public GUIText title;
	public GUIText loading;
	private int loadprogress;
	private GameObject tempbox;
	public GameObject startbutton;
	public GameObject soundbutton;
	public GameObject shopbutton;


	// Use this for initialization
	void Start () {
	sound.instance.mm();
	title.fontSize = (Screen.width)/15;
	start.fontSize = (Screen.width)/25;

	if(PlayerPrefs.GetInt("level1complete") == 1){
		start.text = "Tap to Continue";
	}
	else{
		start.text = "Tap to Begin";
	}
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				tempbox = checkTouch(Input.GetTouch(0).position);

			}
		}
		if(tempbox == startbutton){
			tempbox = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("mainmenu"));

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
	   IEnumerator loadinglevel(string level){

	  	startbutton.SetActive(false);
	  	shopbutton.SetActive(false);
	  	soundbutton.SetActive(false);
    	
    	start.text = "";

	  	loading.fontSize = (Screen.width)/19;
	  	loading.text = "Loading "+ loadprogress +"%";
	  	AsyncOperation async = SceneManager.LoadSceneAsync(level);

	  	while(!async.isDone){
	  		loadprogress = (int)(async.progress * 100);
	  		loading.text = "Loading "+ loadprogress +"%";
	  		yield return null;
	  	}


	  }
}
