using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour {

	public GUIText title;
	public GameObject level1;
	public GameObject level2;
	public GameObject level3;
	public GameObject level4;
	public GameObject level5;
	public GameObject level6;
	public GameObject level7;
	public GameObject level8;
	public GameObject level9;
	public GameObject level10;
	public GameObject level11;
	public GameObject level12;
	public GameObject level13;
	public GameObject level14;
	public GameObject level15;
	public GameObject level16;
	public GameObject level17;
	public GameObject level18;
	public GameObject level19;

	public GameObject level1button;
	public GameObject level2button;
	public GameObject level3button;
	public GameObject level4button;
	public GameObject level5button;
	public GameObject level6button;
	public GameObject level7button;
	public GameObject level8button;
	public GameObject level9button;
	public GameObject level10button;
	public GameObject level11button;
	public GameObject level12button;
	public GameObject level13button;
	public GameObject level14button;
	public GameObject level15button;
	public GameObject level16button;
	public GameObject level17button;
	public GameObject level18button;
	public GameObject level19button;

	public GameObject lock2;
	public GameObject lock3;
	public GameObject lock4;
	public GameObject lock5;

	public GameObject lock7;
	public GameObject lock8;
	public GameObject lock9;
	public GameObject lock10;

	public GameObject lock12;
	public GameObject lock13;
	public GameObject lock14;
	public GameObject lock15;

	public GameObject lock17;
	public GameObject lock18;
	public GameObject lock19;

	public GameObject chapter1;
	public GameObject chapter2;
	public GameObject chapter3;
	public GameObject chapter4;

	private GameObject temp;
	public GUIText loading;
	private int loadprogress;
	public GameObject soundbutton;
	public GameObject shopbutton;

	// Use this for initialization
	void Start () {

		sound.instance.mm();
		temp = null;
		title.fontSize = (Screen.width)/27;
		level2button.GetComponent<Collider2D>().enabled = false;
		level3button.GetComponent<Collider2D>().enabled = false;
		level4button.GetComponent<Collider2D>().enabled = false;
		level5button.GetComponent<Collider2D>().enabled = false;
		level6button.GetComponent<Collider2D>().enabled = false;
		level7button.GetComponent<Collider2D>().enabled = false;
		level8button.GetComponent<Collider2D>().enabled = false;
		level9button.GetComponent<Collider2D>().enabled = false;
		level10button.GetComponent<Collider2D>().enabled = false;
		level11button.GetComponent<Collider2D>().enabled = false;
		level12button.GetComponent<Collider2D>().enabled = false;
		level13button.GetComponent<Collider2D>().enabled = false;
		level14button.GetComponent<Collider2D>().enabled = false;
		level15button.GetComponent<Collider2D>().enabled = false;
		level16button.GetComponent<Collider2D>().enabled = false;
		level17button.GetComponent<Collider2D>().enabled = false;
		level18button.GetComponent<Collider2D>().enabled = false;
		level19button.GetComponent<Collider2D>().enabled = false;


		if(PlayerPrefs.GetInt("level1complete") == 1){

			level1.GetComponent<Animator>().SetBool("complete",true);
			level2button.GetComponent<Collider2D>().enabled = true;
			lock2.SetActive(false);
			level2.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level2complete") == 1){

			level2.GetComponent<Animator>().SetBool("complete",true);
			level3button.GetComponent<Collider2D>().enabled = true;
			lock3.SetActive(false);
			level3.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level3complete") == 1){

			level3.GetComponent<Animator>().SetBool("complete",true);
			level4button.GetComponent<Collider2D>().enabled = true;
			lock4.SetActive(false);
			level4.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level4complete") == 1){

			level4.GetComponent<Animator>().SetBool("complete",true);
			level5button.GetComponent<Collider2D>().enabled = true;
			lock5.SetActive(false);
			level5.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level5complete") == 1){

			level5.GetComponent<Animator>().SetBool("complete",true);
			chapter2.SetActive(true);
			level6button.GetComponent<Collider2D>().enabled = true;

		}
		if(PlayerPrefs.GetInt("level6complete") == 1){

			level6.GetComponent<Animator>().SetBool("complete",true);
			level7button.GetComponent<Collider2D>().enabled = true;
			lock7.SetActive(false);
			level7.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level7complete") == 1){

			level7.GetComponent<Animator>().SetBool("complete",true);
			level8button.GetComponent<Collider2D>().enabled = true;
			lock8.SetActive(false);
			level8.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level8complete") == 1){

			level8.GetComponent<Animator>().SetBool("complete",true);
			level9button.GetComponent<Collider2D>().enabled = true;
			lock9.SetActive(false);
			level9.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level9complete") == 1){

			level9.GetComponent<Animator>().SetBool("complete",true);
			level10button.GetComponent<Collider2D>().enabled = true;
			lock10.SetActive(false);
			level10.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level10complete") == 1){

			level10.GetComponent<Animator>().SetBool("complete",true);
			chapter3.SetActive(true);
			level11button.GetComponent<Collider2D>().enabled = true;	

		}
		if(PlayerPrefs.GetInt("level11complete") == 1){

			level11.GetComponent<Animator>().SetBool("complete",true);
			level12button.GetComponent<Collider2D>().enabled = true;
			lock12.SetActive(false);
			level12.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level12complete") == 1){

			level12.GetComponent<Animator>().SetBool("complete",true);
			level13button.GetComponent<Collider2D>().enabled = true;
			lock13.SetActive(false);
			level13.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level13complete") == 1){

			level13.GetComponent<Animator>().SetBool("complete",true);
			level14button.GetComponent<Collider2D>().enabled = true;
			lock14.SetActive(false);
			level14.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level14complete") == 1){

			level14.GetComponent<Animator>().SetBool("complete",true);
			level15button.GetComponent<Collider2D>().enabled = true;
			lock15.SetActive(false);
			level15.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level15complete") == 1){

			level15.GetComponent<Animator>().SetBool("complete",true);
			level16button.GetComponent<Collider2D>().enabled = true;
			chapter4.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level16complete") == 1){

			level16.GetComponent<Animator>().SetBool("complete",true);
			level17button.GetComponent<Collider2D>().enabled = true;
			lock17.SetActive(false);
			level17.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level17complete") == 1){

			level17.GetComponent<Animator>().SetBool("complete",true);
			level18button.GetComponent<Collider2D>().enabled = true;
			lock18.SetActive(false);
			level18.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level18complete") == 1){

			level18.GetComponent<Animator>().SetBool("complete",true);
			level19button.GetComponent<Collider2D>().enabled = true;
			lock19.SetActive(false);
			level19.SetActive(true);

		}
		if(PlayerPrefs.GetInt("level19complete") == 1){

			level19.GetComponent<Animator>().SetBool("complete",true);
		}		
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				temp = checkTouch(Input.GetTouch(0).position);

			}
		}
		if(temp == level1button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("story1"));

		}
		if(temp == level2button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level2"));

		}
		if(temp == level3button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level3"));

		}
		if(temp == level4button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level4"));

		}
		if(temp == level5button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level5"));

		}
		if(temp == level6button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level6"));

		}
		if(temp == level7button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level7"));

		}
		if(temp == level8button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level8"));

		}
		if(temp == level9button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level9"));

		}
		if(temp == level10button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level10"));

		}
		if(temp == level11button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level11"));

		}
		if(temp == level12button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level12"));

		}
		if(temp == level13button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level13"));

		}
		if(temp == level14button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level14"));

		}
		if(temp == level15button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level15"));

		}
		if(temp == level16button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level16"));

		}
		if(temp == level17button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level17"));

		}
		if(temp == level18button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level18"));

		}
		if(temp == level19button){
			temp = null;
			sound.instance.buttonclick();
			StartCoroutine(loadinglevel("level19"));

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

	  	
    	chapter1.SetActive(false);
    	chapter2.SetActive(false);
    	chapter3.SetActive(false);
    	chapter4.SetActive(false);
    	soundbutton.SetActive(false);
    	shopbutton.SetActive(false);

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
