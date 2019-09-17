using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class spashscreen : MonoBehaviour {

	
	private int loadprogress = 0;
	private bool check;
	GameObject levelz;
	public GUIText loadingz;

	// Use this for initialization
	void Start () {
		
		check = false;
	}
	void Awake(){

		

	}
	
	// Update is called once per frame
	void Update () {

		if(!check){
			check = true;
			StartCoroutine("Delay");
		}
	
	}
	IEnumerator Delay(){

        yield return new WaitForSeconds(2);

        StartCoroutine(loadinglevel("openingscene"));

        
     }

	IEnumerator loadinglevel(string level){

    

       
        loadingz.fontSize = (Screen.width)/19;
        loadingz.text = "Loading "+ loadprogress +"%";
        AsyncOperation async = SceneManager.LoadSceneAsync(level);

        while(!async.isDone){
            loadprogress = (int)(async.progress * 100);
            loadingz.text = "Loading "+ loadprogress +"%";
           yield return null;
        }
        


      }

}

