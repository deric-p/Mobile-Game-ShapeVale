using UnityEngine;
using System.Collections;

public class Mainmenuscript : MonoBehaviour {

	public GameObject shop;
	private GameObject [] buttons;
	private GameObject [] onbuttons;
	private int j;
	private bool done;

	// Use this for initialization
	void Start () {
		done = false;

	}
	
	// Update is called once per frame
	void Update () {
		if((shop.activeSelf)&&
			(!done)){
			j =0;
			buttons = GameObject.FindGameObjectsWithTag("buttons");
			for(int i=0;i<buttons.Length;i++){
				if(buttons[i].GetComponent<Collider2D>().enabled == true){		
				j++;
				}
			}
			GameObject [] temparray = new GameObject[j];
			j=0;
			for(int i=0;i<buttons.Length;i++){
				if(buttons[i].GetComponent<Collider2D>().enabled == true){		
				temparray[j]=buttons[i];
				buttons[i].GetComponent<Collider2D>().enabled = false;
				j++;
				}
			}
			done = true;
			onbuttons = temparray;
			}
			
	 if((!shop.activeSelf)&&(done)){
	 	for(int i=0;i<onbuttons.Length;i++){
	 		onbuttons[i].GetComponent<Collider2D>().enabled = true;
	 	}
			
			done = false;
	 }
	}
}
