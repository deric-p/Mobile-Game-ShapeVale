using UnityEngine;
using System.Collections;

public class spikedball : MonoBehaviour {

	public GameObject defeat;
	private bool defeated;
	public GameObject pause;
	public GameObject victorious;
	public GameObject victory;
	private bool complete;
	private int health;
	public GameObject arrow1;
	public GameObject boss;
	public GameObject bossdie;
	public GameObject arrow1explode;
	public GameObject arrow2explode;
	private Vector3 arrow1position;
	private Vector3 arrow2position;
	public  GameObject arrow2;
	public GUIText countdown;
	public GUIText hp;
	public GameObject top;
	public GameObject bottom;
	private Vector3 topposition;
	private Vector3 bottomposition;
	private float toptemp;
	private float bottomtemp;
	private GameObject [] platforms;
	public GameObject [] blocks;
	public GameObject s1;
	public GameObject s2;
	public GameObject s3;
	public GameObject s4;
	public static GameObject switch1;
	public static GameObject switch2;
	public static GameObject switch3;
	public static GameObject switch4;
	private bool switchcomp1;
	private bool switchcomp2;
	private bool switchcomp3;
	private bool switchcomp4;
	private int countdownnumber;
	private bool reset;
	private bool death;
	private int counter;
	private bool callat20;
	private bool callat28;
	private bool callat30;
	private static bool switch1set;
	private static bool switch2set;
	private bool arrow1hit;
	private bool arrow2hit;
	private float increment;
	private float temp1arrow;
	private float temp2arrow;
	private bool reset1arrow;
	private bool reset2arrow;
	private bool switched;
	private bool resetoccured;
	private bool callat25;
	
	

	// Use this for initialization
	void Start () {
		sound.instance.boss();
		platforms = GameObject.FindGameObjectsWithTag("platformspikey");
		
		resetoccured = true;
		countdown.text = "";
		health = 100;
		complete = false;
		switchcomp1 = false;
		reset1arrow = false;
		reset2arrow = false;
		switchcomp2 = false;
		switchcomp3 = false;
		callat25 = false;
		switched = false;
		switch1 = s1;
		switch2 = s2;
		switch3 = s3;
		switch4 = s4;
		switchcomp4 = false;
		switch1set = false;
		switch2set = false;
		arrow1hit = false;
		arrow2hit = false;
		increment = 0.05f;
		counter = 25;
		StartCoroutine("turnonarrows");
		arrow1position = arrow1.transform.position;
		arrow2position = arrow2.transform.position;
		topposition = top.transform.position;
		toptemp = topposition.x;
		bottomtemp = bottomposition.x;
		bottomposition = bottom.transform.position;
		temp1arrow = arrow1position.x;
		temp2arrow = arrow2position.y;
		hp.fontSize = (Screen.width)/27;
		countdown.fontSize = (Screen.width)/27;
		countdown.text="";
		defeated = false;
		death = false;
		switch2.GetComponent<Animator>().SetBool("off",true);
		switch3.GetComponent<Animator>().SetBool("off",true);

		countdownnumber = 10;
		switchcomp1 = true;
		reset = false;
		
		StartCoroutine("counttodeaddeath");
	}
	void switcher(){

		if((switchcomp1)&&
			(!switched)){
			if((!switch2.activeSelf)&&
				(!switch3.activeSelf)){
				switch2.SetActive(true);
				switch3.SetActive(true);
			}
			switch2.GetComponent<Animator>().SetBool("off",false);
			switch3.GetComponent<Animator>().SetBool("off",false);
			switched = true;
			switchcomp1 = false;
			switchcomp2 = true;
			
			
		}
		if((switchcomp2)&&
			(!switched)){
			switch2.GetComponent<Animator>().SetBool("off",false);
			switch1.GetComponent<Animator>().SetBool("off",false);
			switched = true;
			switchcomp2 = false;
			switchcomp3 = true;
			
			
		}
		if((switchcomp3)&&
			(!switched)){
			
			switch3.GetComponent<Animator>().SetBool("off",false);
			switch4.GetComponent<Animator>().SetBool("off",false);
			switched= true;
			switchcomp3 = false;
			switchcomp4 = true;
			
		}
		if((switchcomp4)&&
			(!switched)){
			
			switch1.GetComponent<Animator>().SetBool("off",false);
			switch4.GetComponent<Animator>().SetBool("off",false);
			switched = true;
			switchcomp4 = false;
			switchcomp1 = true;
			
		}


	}
	public static void switcher1(){

		if(!switch1.GetComponent<Animator>().GetBool("switch")){
			if(switch1set){
				sound.instance.starswitch();
				switch2set = true;
			}
			else{
				sound.instance.starswitch();
				switch1set = true;
			}
		}

		switch1.GetComponent<Animator>().SetBool("switch",true);	

	}
	public static void switcher2(){

		if(!switch2.GetComponent<Animator>().GetBool("switch")){
			if(switch1set){
				sound.instance.starswitch();
				switch2set = true;
			}
			else{
				sound.instance.starswitch();
				switch1set = true;
			}
		}

		switch2.GetComponent<Animator>().SetBool("switch",true);	

	}
	public static void switcher3(){

		if(!switch3.GetComponent<Animator>().GetBool("switch")){
			if(switch1set){
				sound.instance.starswitch();
				switch2set = true;
			}
			else{
				sound.instance.starswitch();
				switch1set = true;
			}
		}

		switch3.GetComponent<Animator>().SetBool("switch",true);	

	}
	public static void switcher4(){

		if(!switch4.GetComponent<Animator>().GetBool("switch")){
			if(switch1set){
				sound.instance.starswitch();
				switch2set = true;
			}
			else{
				sound.instance.starswitch();
				switch1set = true;
			}
		}

		switch4.GetComponent<Animator>().SetBool("switch",true);	

	}

	void explodearrow1(){
		reset1arrow = true;
		arrow1.SetActive(false);
		arrow1explode.SetActive(true);
		StartCoroutine(decreasehealth(3));
		sound.instance.bubbledmg();
		StartCoroutine("resetArrow1");
	}
	IEnumerator resetArrow1(){
		yield return new WaitForSeconds(1);
		reset1arrow = false;
		arrow1hit = false;
		arrow1.SetActive(true);
		arrow1.transform.position = new Vector3(arrow1position.x,arrow1position.y,arrow1position.z);
		temp1arrow = arrow1position.x;
		arrow1explode.SetActive(false);
	}
	void explodearrow2(){
		reset2arrow = true;
		arrow2.SetActive(false);
		StartCoroutine(decreasehealth(3));
		arrow2explode.SetActive(true);
		sound.instance.bubbledmg();
		StartCoroutine("resetArrow2");
	}
	IEnumerator resetArrow2(){
		yield return new WaitForSeconds(1);
		reset2arrow = false;
		arrow2hit = false;
		arrow2.SetActive(true);
		arrow2.transform.position = new Vector3(arrow2position.x,arrow2position.y,arrow2position.z);
		temp2arrow = arrow2position.y;
		arrow2explode.SetActive(false);
	}
	IEnumerator risingspikes(){

		
		
		while(((top.transform.position.x >=0))&&
			((bottom.transform.position.y<=0))){
			yield return new WaitForSeconds(0.005f);

			toptemp = toptemp-increment;
			top.transform.position = new Vector3(topposition.x,toptemp,topposition.z);
			bottomtemp = bottomtemp+increment;
			bottom.transform.position = new Vector3(bottomposition.x,bottomtemp,bottomposition.z);
		}
	}
	IEnumerator shrinkingspikes(){

		while((!(top.transform.position.x >=1.5))&&
			(!(bottom.transform.position.y<=-1.5))){
			yield return new WaitForSeconds(0.005f);
			toptemp = toptemp+increment;
			top.transform.position = new Vector3(topposition.x,toptemp,topposition.z);
			bottomtemp = bottomtemp-increment;
			bottom.transform.position = new Vector3(bottomposition.x,bottomtemp,bottomposition.z);
		}
	}

	void FixedUpdate(){
		if((arrow1.transform.position.x <= -5.8)&&
			(!arrow1hit)){
			arrow1hit = true;
		}
		if((arrow2.transform.position.y >= 1.8)&&
			(!arrow2hit)){
			arrow2hit = true;
		}

		if((switch1set)&&
			(switch2set)){
			if(arrow1hit){
				if(!reset1arrow){
					explodearrow1();
				}
			}
			else if((!arrow1hit)&&
				(!reset1arrow)){
				temp1arrow = temp1arrow -increment;
				arrow1.transform.position = new Vector3(temp1arrow,arrow1position.y,arrow1position.z);
			}
			if(arrow2hit){
				if(!reset2arrow){
					explodearrow2();
				}
			}
			else if((!arrow2hit)&&
				(!reset2arrow)){
				temp2arrow = temp2arrow + increment;
				arrow2.transform.position = new Vector3(arrow2position.x,temp2arrow,arrow2position.z);
			}
			
		}
		
	}
	// Update is called once per frame
	void Update () {

		
		if((health <= 0)&&(!complete)){
			sound.instance.stardie();
			health = 0;
			victory.SetActive(true);
			complete = true;
			arrow1.SetActive(false);
			arrow2.SetActive(false);
			switch1set = false;
			switch2set = false;
			boss.SetActive(false);
			bossdie.SetActive(true);


		}
		if(death){
			death = false;
			StartCoroutine("risingspikes");
		}
		if((counter == 10)&&(!callat20)){
			callat20 = true;
			StartCoroutine("beforedeathphase");
		}
		if((counter == 1)&&(!callat28)){
			callat28 = true;
			StartCoroutine("flashingplatforms");
		}
		if((counter  == 3)&&(!callat25)){
			callat25 = true;
			switch1set = false;
			switch2set = false;
			arrow1.SetActive(false);
			arrow2.SetActive(false);
		}
		if((counter == -1)&&(!callat30)){
			callat30 = true;
			StartCoroutine("deathphase");
		}
		
		if(reset){

			reset = false;
			StartCoroutine("reseteverything");
			
			StartCoroutine("shrinkingspikes");
		}
		if((counter == -10)&&(!reset)&&
			(!resetoccured)){
			resetoccured = true;
			reset = true;
		}

		if((defeat.activeSelf)||
			(pause.activeSelf)||
			(victorious.activeSelf)){
			hp.text="";
					}
		else{
			hp.text = "The Black Star: "+health+"%";

		}
		if((defeat.activeSelf)&&(!defeated)){
			health = 100;
			defeated = true;
			switch1set = false;
			switch2set = false;
			arrow1.SetActive(false);
			arrow2.SetActive(false);
			
				switch1.GetComponent<Animator>().SetBool("off",true);
				switch1.GetComponent<Animator>().SetBool("switch",false);
				switch4.GetComponent<Animator>().SetBool("off",true);
				switch4.GetComponent<Animator>().SetBool("switch",false);
				switch2.GetComponent<Animator>().SetBool("off",true);
				switch3.GetComponent<Animator>().SetBool("off",true);
				switch2.GetComponent<Animator>().SetBool("switch",false);
				switch3.GetComponent<Animator>().SetBool("switch",false);

		}
		if((!defeat.activeSelf)&&
			(defeated)){
		 
			
			defeated = false;
			reset = true;
			death = false;
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
			if((!defeat.activeSelf)){
				health--;
			}
			
			

			}

	}
	IEnumerator counttodeaddeath(){

		while(counter!=-11){
		yield return new WaitForSeconds(1);
		if((!defeat.activeSelf)&&
			(!complete)){
			counter--;
		}
		
		}
	}
	IEnumerator beforedeathphase(){
		yield return null;
		callat20 = true;
		StartCoroutine("countingdown");

	}

	IEnumerator flashingplatforms(){
		if(counter <= 2){
		callat28 = true;
		switch1set = false;
		switch2set = false;
		arrow1.SetActive(false);
		arrow2.SetActive(false);
		for(int i=0;i<platforms.Length;i++){
			platforms[i].GetComponent<Animator>().SetBool("turnoff",true);
		}
		
		switch1.GetComponent<Animator>().SetBool("turnoff",true);
		switch4.GetComponent<Animator>().SetBool("turnoff",true);
		switch2.GetComponent<Animator>().SetBool("turnoff",true);
		switch3.GetComponent<Animator>().SetBool("turnoff",true);
	  StartCoroutine("turnswitchesoff");
		arrow1.SetActive(false);
		arrow2.SetActive(false);
		
		}
	
				
		
		yield return new WaitForSeconds(2);
		if(counter <= 2){
			for(int i=0;i<blocks.Length;i++){
				
				blocks[i].GetComponent<Collider2D>().enabled = false;
				
			}
		}
			
	}
	IEnumerator turnswitchesoff(){
		yield return new WaitForSeconds(1);
		if(counter<=2){
			
			switch1.GetComponent<Animator>().SetBool("off",true);
			switch4.GetComponent<Animator>().SetBool("off",true);
			switch1.GetComponent<Animator>().SetBool("switch",false);
			switch4.GetComponent<Animator>().SetBool("switch",false);
			switch1.GetComponent<Animator>().SetBool("turnoff",false);
			switch4.GetComponent<Animator>().SetBool("turnoff",false);
			switch2.GetComponent<Animator>().SetBool("off",true);
			switch3.GetComponent<Animator>().SetBool("off",true);
			switch2.GetComponent<Animator>().SetBool("switch",false);
			switch3.GetComponent<Animator>().SetBool("switch",false);
			switch2.GetComponent<Animator>().SetBool("turnoff",false);
			switch3.GetComponent<Animator>().SetBool("turnoff",false);


		}
		
	}
	IEnumerator countingdown(){

		resetoccured = false;
		for(int i =0;i<11;i++){
			if(counter <= 10){
				countdown.text = countdownnumber+"...";
			}
			yield return new WaitForSeconds(1);
			if(counter <= 10){
				countdownnumber--;
				countdown.text = countdownnumber+"...";
			}
			if(i == 10){
				countdown.text = "";
				countdownnumber = 10;
			}
			
		}
	}
	IEnumerator deathphase(){
		yield return null;
		arrow1.SetActive(false);
		arrow2.SetActive(false);
		callat30 = true;
		death = true;
		countdown.text = "";
		
	}
	IEnumerator reseteverything(){
		yield return null;
		for(int i=0;i<platforms.Length;i++){
			platforms[i].GetComponent<Animator>().SetBool("turnoff",false);
		}
		for(int i=0;i<blocks.Length;i++){
				
			blocks[i].GetComponent<Collider2D>().enabled = true;
				
		}
		StartCoroutine("turnonarrows");
		switched = false;
		
		switcher();
		switch1set = false;
		switch2set = false;
		death = false;
		reset = false;
		countdown.text="";
		countdownnumber = 10;
		counter = 25;
		callat30 = false;
		callat20 = false;
		callat28 = false;
		callat25 = false;

	}
	IEnumerator turnonarrows(){
		yield return new WaitForSeconds(1);
		arrow1.SetActive(true);
		arrow2.SetActive(true);
		arrow1.transform.position = new Vector3(arrow1position.x,arrow1position.y,arrow1position.z);
		arrow2.transform.position = new Vector3(arrow2position.x,arrow2position.y,arrow2position.z);
	}
}