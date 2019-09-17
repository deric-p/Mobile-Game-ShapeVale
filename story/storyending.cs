using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class storyending : MonoBehaviour {
private string story;
	private string storylin;
	public GameObject startlevel;
	public GUIStyle style;
	public GUIText loading;
	private int loadprogress;
	
	private bool running;
	char [] array;
	private GameObject tempbox;

	// Use this for initialization
	void Start () {
		sound.instance.bg();
		tempbox = null;
		storylin ="The final titan was defeated and now shape vale is save for now….";
		
		running = false;
		style.fontSize = ((Screen.width)/30);
		

		StartCoroutine(storyline(storylin));
	}

	void OnGUI()
	{  
	    
	    GUI.Label(new Rect(100,25, Screen.width-150,Screen.height), story, style);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touchCount > 0){

            if(Input.GetTouch(0).phase == TouchPhase.Began){
                //temp box
                 tempbox = checkTouch(Input.GetTouch(0).position);
                 
            }
        }

        if(tempbox == startlevel){
        	tempbox = null;
            sound.instance.buttonclick();
            running = false;
        	StartCoroutine(loadinglevel("mainmenu"));
        }
	
	}

	 IEnumerator storyline(string storynum){
        running = true;
    	array = storynum.ToCharArray();
    	for(int i=0;i<array.Length;i++){
            
    		if(!running){
                array = null;
    			break;

    		}
    		story += array[i];

            if(i == array.Length-1){
                array = null;
                running = false;
                break;
            }
    		
    		yield return new WaitForSeconds(0.05f);
    	}

    	
    }
    IEnumerator loadinglevel(string level){

        startlevel.SetActive(false);
        story = "";
       	running = false;
        loading.fontSize = (Screen.width)/19;
        loading.text = "Loading "+ loadprogress +"%";
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while(!async.isDone){
            loadprogress = (int)(async.progress * 100);
            loading.text = "Loading "+ loadprogress +"%";
           yield return null;
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
}
