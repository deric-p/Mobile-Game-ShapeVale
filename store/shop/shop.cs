using UnityEngine;
using System.Collections;
using Soomla;
using Soomla.Store;
using System;
using System.Collections.Generic;


public class shop : MonoBehaviour {

	public GameObject shopbutton;
	public GameObject shopoption;
	public GameObject close;
	public GameObject removeads;
	public GameObject start;
	private int balance;
	private bool done;
	private GameObject tempbox;
	
	// Use this for initialization
	void Start () {
		balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
		done = false;
		tempbox = null;
		removeads.GetComponent<Animator>().SetBool("off",true);
		
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
		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				tempbox = checkTouch(Input.GetTouch(0).position);

			}
		}
		
		if(tempbox == shopbutton){
			tempbox = null;
			shopbutton.SetActive(false);
			shopoption.SetActive(true);
			removeads.GetComponent<Animator>().SetBool("off",false);
			removeads.GetComponent<Collider2D>().enabled = true;
			start.SetActive(false);
			balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
		}
		if(tempbox == close){
			tempbox = null;
			shopbutton.SetActive(true);
			shopoption.SetActive(false);
			start.SetActive(true);
			removeads.GetComponent<Collider2D>().enabled = false;
			removeads.GetComponent<Animator>().SetBool("off",true);
			balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);

		}
		if(tempbox == removeads){
			Debug.Log("test");
			tempbox = null;
			VirtualGood no_ads = ShapeValeStore.NO_ADS_LTVG; 
			try{
				StoreInventory.BuyItem(no_ads.ItemId);
			}catch (Exception e){
				Debug.Log("error occured: "+e);
			}
		}
		
		if(balance > 0){
			if((removeads.activeSelf)&&(!done)){
				removeads.GetComponent<Animator>().SetBool("purchased",true);
				removeads.GetComponent<Collider2D>().enabled = false;
				done = true;
			}
			
		}
		else{

		}
	
	}
}
