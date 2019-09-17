using UnityEngine;
using System.Collections;
using Soomla;
using Soomla.Store;
using System;

public class removeadsbutton : MonoBehaviour {

	public GameObject removeads;
	private GameObject screens;
	private GameObject defeat;
	private bool defeated;
	private GameObject victory;
	private bool victorious;
	private GameObject pause;
	private bool paused;
	private int balance;
	private GameObject tempbox;
	private GameObject adz;

	// Use this for initialization
	void Start () {
		balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
		tempbox = null;
		screens = GameObject.FindGameObjectWithTag("screens").gameObject;
		AssignScreens(screens);
		defeated= false;
		victorious = false;
		paused = false;
		adz = null;
		if (GameObject.FindGameObjectWithTag("ads") != null){
			adz = GameObject.FindGameObjectWithTag("ads").gameObject;
		}
		if((balance >0)&&(adz !=null)){
			ads.destroystarting();
		}
		if((balance >0)&&(adz !=null)&&(ads.destroyending())){
			Destroy(adz);
			
		}
{
    //it exists
}
	
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
	
	// Update is called once per frame
	void Update () {
		if((balance >0)&&(adz !=null)){
			ads.destroystarting();
		}
		if((balance >0)&&(adz !=null)&&(ads.destroyending())){
			Destroy(adz);
			adz = null;
		}
		if(Input.touchCount > 0){

			if(Input.GetTouch(0).phase == TouchPhase.Began){

				tempbox = checkTouch(Input.GetTouch(0).position);

			}
		}
		if((defeat.activeSelf)&&
			(!defeated)){
			balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
			if(balance > 0){
				defeated = true;
			}
			else{
				defeated = true;
				removeads.SetActive(true);
			}
		}
		if((!defeat.activeSelf)&&
			(defeated)){
			defeated = false;
			removeads.SetActive(false);
		}
		if((victory.activeSelf)&&
			(!victorious)){
			balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
			if(balance > 0){
				victorious = true;
			}
			else{
				victorious = true;
				removeads.SetActive(true);
			}
		}
		if((!victory.activeSelf)&&
			(victorious)){
			victorious = false;
			removeads.SetActive(false);
		}
		if((pause.activeSelf)&&
			(!paused)){
			balance = StoreInventory.GetItemBalance(ShapeValeStore.NO_ADS_LIFETIME_PRODUCT_ID);
			if(balance > 0){
				paused = true;
			}
			else{
				paused = true;
				removeads.SetActive(true);
			}
		}
		if((!pause.activeSelf)&&
			(paused)){
			paused = false;
			removeads.SetActive(false);
		}
		if(tempbox == removeads){
			tempbox = null;
			VirtualGood no_ads = ShapeValeStore.NO_ADS_LTVG; 
			try{
				StoreInventory.BuyItem(no_ads.ItemId);
			}catch (Exception e){
				Debug.Log("error occured: "+e);
			}
		}
	
	}
}
