using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class story1 : MonoBehaviour {

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
		storylin ="In ancient times, there were titans that plagued shape vale,"+
		" but they were imprisoned. Over the years the prison weakened and the titans escaped."+
		" The titans have to be stopped in order to save shape vale…. ";
		
		
		style.fontSize = ((Screen.width)/30);
		
        running = true;
		StartCoroutine(storyline(storylin));
	}

	void OnGUI()
	{  
	    if(running){
            GUI.Label(new Rect(100,25, Screen.width-150,Screen.height), story, style);
        }
        else{
            story="";
        }
	    
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
            running = false;
            sound.instance.buttonclick();
        	StartCoroutine(loadinglevel("level1"));
        }
	
	}

	 IEnumerator storyline(string storynum){
        
    	array = storynum.ToCharArray();
    	for(int i=0;i<array.Length;i++){
            
    		if(!running){
                array = null;
    			break;

    		}
            if(running){
                story += array[i];

            if(i == array.Length-1){
                array = null;
                
                break;
            }
            }
    		
    		
    		yield return new WaitForSeconds(0.05f);
    	}

    	
    }
    IEnumerator loadinglevel(string level){

        startlevel.SetActive(false);
        story = "";
       
        loading.fontSize = (Screen.width)/19;
        loading.text = "Loading "+ loadprogress +"%";
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while(!async.isDone){
            story = "";
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
