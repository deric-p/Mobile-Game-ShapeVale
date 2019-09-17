using UnityEngine;
using System.Collections;

public class lamp : MonoBehaviour {

	public GameObject circle;
	public Animator circleanimator;
	public Animator lamps;
	public GameObject explode_tag;
	private GameObject explode_circle;
	public GameObject defeat;
	public GameObject node1_teal;
	public GameObject node1_purple;
	public GameObject node2_green;
	public GameObject node2_purple;
	public GameObject node2_teal;
	public GameObject node3_yellow;
	public GameObject node3_orange;
	public GameObject node3_black;
	public GameObject node4_blue;
	public GameObject node4_red;
	public GameObject node4_orange;
	public GameObject node5_red;
	public GameObject node5_blue;
	public GameObject node_white;
	private bool complete;
	private int circlecolor;
	public GUIText hp;
	private int health;
	public GameObject crossing1;
	public GameObject crossing2;
	public GameObject crossing3;
	public GameObject crossing4;
	public GameObject crossing5;
	public GameObject victory;
	public GameObject victoryscreen;
	public GameObject pausescreen;
	private bool levelcomplete;
	private GameObject [] tealspot;
	private GameObject [] bluespot;
	private GameObject [] purplespot;
	private GameObject [] greenspot;
	private GameObject [] yellowspot;
	private GameObject [] redspot;
	private GameObject [] blackspot;
	private GameObject [] orangespot;
	private GameObject [] whitespot;
	private bool process;
	private bool defeatwasactive;


	// Use this for initialization
	void Start () {
		sound.instance.boss();
		complete = false;
		health = 100;
		process = false;
		defeatwasactive = false;
		hp.fontSize = (Screen.width)/27;
		levelcomplete = false;
		tealspot = GameObject.FindGameObjectsWithTag("tealspot");
		bluespot = GameObject.FindGameObjectsWithTag("bluespot");
		purplespot = GameObject.FindGameObjectsWithTag("purplespot");
		whitespot = GameObject.FindGameObjectsWithTag("whitelampspots");
		greenspot = GameObject.FindGameObjectsWithTag("greenspot");
		yellowspot = GameObject.FindGameObjectsWithTag("yellowspot");
		redspot = GameObject.FindGameObjectsWithTag("redspot");
		blackspot = GameObject.FindGameObjectsWithTag("blackspot");
		orangespot = GameObject.FindGameObjectsWithTag("orangespot");

	}

	void explodecircle(GameObject circle){

	circlecolor = circleanimator.GetInteger("switch");
	
	Transform [] circlechildren = circle.GetComponentsInChildren<Transform> (true);

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

	IEnumerator TurnOffNode(GameObject node){
		node.GetComponent<Animator>().SetBool("turnoff",true);
		yield return new WaitForSeconds(1f);
		node.GetComponent<Animator>().SetBool("turnoff",false);
		node.SetActive(false);
	}
	// Update is called once per frame
	void Update () {

		if((victoryscreen.activeSelf)||
			(defeat.activeSelf)||
			(pausescreen.activeSelf)){
			hp.text = "";
		}else{
			hp.text = "The Lamp: "+health+"%";
		}
		
		if((hp.text == "The Lamp: 0%")&&
		(!levelcomplete)){
		levelcomplete = true;
		victory.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==0)){
			complete = true;
			node2_green.SetActive(true);
			node_white.SetActive(true);
			node3_yellow.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==1)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			
			node4_blue.SetActive(true);
			node5_red.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==2)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			
			node1_teal.SetActive(true);
			node2_green.SetActive(true);
			node3_yellow.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==3)){
			complete = true;
			StartCoroutine(TurnOffNode(node3_yellow));
			
			node3_orange.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==4)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			
			node2_purple.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==5)){
			complete = true;
			StartCoroutine(TurnOffNode(node2_purple));
			node4_red.SetActive(true);
			node5_blue.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==6)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			
			node1_purple.SetActive(true);
			node2_teal.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==7)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			
			node3_black.SetActive(true);
			node4_orange.SetActive(true);
			node5_blue.SetActive(true);
		}
		if((!complete)&&(lamps.GetInteger("lamp")==8)){
			complete = true;
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			node_white.SetActive(false);
			crossing1.SetActive(false);
			crossing2.SetActive(false);
			crossing3.SetActive(false);
			crossing4.SetActive(false);
			crossing5.SetActive(false);
			victory.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==5)&&
			(lamps.GetInteger("lamp")==0)){
			lamps.SetInteger("lamp",1);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(12));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==4)&&
			(lamps.GetInteger("lamp")==1)){
			lamps.SetInteger("lamp",2);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(12));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==1)&&
			(lamps.GetInteger("lamp")==2)){
			lamps.SetInteger("lamp",3);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(13));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==6)&&
			(lamps.GetInteger("lamp")==3)){
			lamps.SetInteger("lamp",4);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(12));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==7)&&
			(lamps.GetInteger("lamp")==4)){
			lamps.SetInteger("lamp",5);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(13));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==8)&&
			(lamps.GetInteger("lamp")==5)){
			lamps.SetInteger("lamp",6);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(12));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==2)&&
			(lamps.GetInteger("lamp")==6)){
			lamps.SetInteger("lamp",7);
			sound.instance.swaplamp();
			StartCoroutine(decreasehealth(13));
			complete = false;
		}
		if((circleanimator.GetInteger("switch")==3)&&
			(lamps.GetInteger("lamp")==7)){
			lamps.SetInteger("lamp",8);
			sound.instance.cactusdie();
			StartCoroutine(decreasehealth(13));
			complete = false;
		}
		if((pausescreen.activeSelf)&&
			(!process)){
			process= true;
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = false;
			}
		}
		if((defeat.activeSelf)&&
			(!process)){
			
			health = 100;
			defeatwasactive = true;
			lamps.SetInteger("lamp",0);
			node1_teal.SetActive(false);
			node1_purple.SetActive(false);
			node2_green.SetActive(false);
			node2_purple.SetActive(false);
			node2_teal.SetActive(false);
			node3_yellow.SetActive(false);
			node3_orange.SetActive(false);
			node3_black.SetActive(false);
			node4_blue.SetActive(false);
			node4_red.SetActive(false);
			node4_orange.SetActive(false);
			node5_red.SetActive(false);
			node5_blue.SetActive(false);
			node_white.SetActive(false);
			process= true;
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = false;
			}
		}
		if((victoryscreen.activeSelf)&&
			(!process)){
			process= true;
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = false;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = false;
			}
		}
		if((!pausescreen.activeSelf)&&
			(process)&&
			(!defeatwasactive)){
			process= false;
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = true;
			}
		}
		if((!defeat.activeSelf)&&
			(process)&&
			(defeatwasactive)){
			process= false;
			complete = false;
			defeatwasactive = false;
			if(circleanimator.GetInteger("switch") !=0){
				circleanimator.SetInteger("switch",0);
			}
			circle.GetComponent<Collider2D>().enabled = true;
			circle.GetComponent<Rigidbody2D>().isKinematic = false;
			
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = true;
			}
		}
		if((!victoryscreen.activeSelf)&&
			(process)&&
			(!defeatwasactive)){
			process= false;
			for(int i=0;i<tealspot.Length;i++){
				tealspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<yellowspot.Length;i++){
				yellowspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<bluespot.Length;i++){
				bluespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<greenspot.Length;i++){
				greenspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<orangespot.Length;i++){
				orangespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<purplespot.Length;i++){
				purplespot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<redspot.Length;i++){
				redspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<blackspot.Length;i++){
				blackspot[i].GetComponent<Collider2D>().enabled = true;
			}
			for(int i=0;i<whitespot.Length;i++){
				whitespot[i].GetComponent<Collider2D>().enabled = true;
			}
		}	
	}

	void OnTriggerEnter2D(Collider2D other){
		explodecircle(explode_tag);
		if((circleanimator.GetInteger("switch")==0)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "greenspot")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==1)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==2)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "greenspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==3)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "greenspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==4)&&
			((other.gameObject.tag == "greenspot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==5)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "greenspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==6)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "greenspot")||
			 (other.gameObject.tag == "purplespot")||
			 (other.gameObject.tag == "redspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}
		if((circleanimator.GetInteger("switch")==7)&&
			((other.gameObject.tag == "bluespot")||
			 (other.gameObject.tag == "whitelampspots")|
			 (other.gameObject.tag == "tealspot")||
			 (other.gameObject.tag == "blackspot")||
			 (other.gameObject.tag == "yellowspot")||
			 (other.gameObject.tag == "orangespot")||
			 (other.gameObject.tag == "redspot")||
			 (other.gameObject.tag == "greenspot"))){
			circleanimator.SetInteger("switch",9);
			circle.GetComponent<Collider2D>().enabled = false;
			circle.GetComponent<Rigidbody2D>().isKinematic = true;
       		explode_circle.SetActive(true);
		}

		if(other.gameObject.tag =="whitepickup"){
			if(circleanimator.GetInteger("switch")!=0){
				circleanimator.SetInteger("switch",0);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOutWhite(other.gameObject));
		}
		if(other.gameObject.tag =="greenpickup"){
			if(circleanimator.GetInteger("switch")!=1){
				circleanimator.SetInteger("switch",1);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="tealpickup"){
			if(circleanimator.GetInteger("switch")!=2){
				circleanimator.SetInteger("switch",2);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="blackpickup"){
			if(circleanimator.GetInteger("switch")!=3){
				circleanimator.SetInteger("switch",3);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="bluepickup"){
			if(circleanimator.GetInteger("switch")!=4){
				circleanimator.SetInteger("switch",4);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="yellowpickup"){
			if(circleanimator.GetInteger("switch")!=5){
				circleanimator.SetInteger("switch",5);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="orangepickup"){
			if(circleanimator.GetInteger("switch")!=6){
				circleanimator.SetInteger("switch",6);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="purplepickup"){
			if(circleanimator.GetInteger("switch")!=7){
				circleanimator.SetInteger("switch",7);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
		if(other.gameObject.tag =="redpickup"){
			if(circleanimator.GetInteger("switch")!=8){
				circleanimator.SetInteger("switch",8);
				sound.instance.ballswap();
			}
			StartCoroutine(FadeOut(other.gameObject,lamps.GetInteger("lamp")));
		}
	}
	IEnumerator decreasehealth(int number){
	
	
		for(int i=0;i<number;i++){
			if(health == 0){
				break;
			}
			if(defeat.activeSelf){
				break;
			}
			yield return new WaitForSeconds(0.05f);
			if(!defeat.activeSelf){
				health--;
			}
			
			

			}

	}
	IEnumerator FadeOut(GameObject node,int currentlamp){
		node.GetComponent<Animator>().SetBool("turnoff",true);
		yield return new WaitForSeconds(1);
		if(currentlamp == lamps.GetInteger("lamp")){
			node.SetActive(false);
			StartCoroutine(TurnOn(node,currentlamp));
		}
	}
	IEnumerator TurnOn(GameObject node, int currentlamp){
		yield return new WaitForSeconds(5);
		if(currentlamp == lamps.GetInteger("lamp")){
			node.SetActive(true);
		}
	}
	IEnumerator FadeOutWhite(GameObject node){
		node.GetComponent<Animator>().SetBool("turnoff",true);
		yield return new WaitForSeconds(1f);
		node.GetComponent<Animator>().SetBool("turnoff",false);
		node.SetActive(false);
		StartCoroutine(TurnOnWhite(node));
	}
	IEnumerator TurnOnWhite(GameObject node){
		yield return new WaitForSeconds(10f);
		node.SetActive(true);
	}
}
