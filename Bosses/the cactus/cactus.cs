using UnityEngine;
using System.Collections;

public class cactus : MonoBehaviour {

	public GameObject spike1;
	private float spike1x;
	private Vector3 spikey1;
	public GameObject spike2;
	private float spike2y;
	private Vector3 spikey2;
	public GameObject spike3;
	private float spike3y;
	private Vector3 spikey3;
	public GameObject spike4;
	private float spike4y;
	private Vector3 spikey4;
	public GameObject spike5;
	private float spike5x;
	private Vector3 spikey5;
	public GameObject dmgspike1;
	public GameObject dmgexplode1;
	public GameObject dmgspike2;
	public GameObject dmgexplode2;
	public GameObject dmgspike3;
	public GameObject dmgexplode3;
	public GameObject dmgspike4;
	public GameObject dmgexplode4;
	public GameObject dmgspike5;
	public GameObject dmgexplode5;
	private Vector3 dmg1;
	private Vector3 dmg2;
	private Vector3 dmg3;
	private Vector3 dmg4;
	private Vector3 dmg5;
	private float temp1;
	private float temp2;
	private float temp3;
	private float temp4;
	private float temp5;
	public GameObject wall1;
	private bool wall1on;
	public GameObject wall2;
	private bool wall2on;
	public GameObject wall3;
	private bool wall3on;
	public GameObject wall4;
	private bool wall4on;
	public GameObject wall5;
	private bool wall5on;
	public GameObject platform1;
	public GameObject platform2;
	public GameObject platform3;
	public GameObject platform4;
	public GameObject platform5;
	private bool reset1;
	private bool reset2;
	private bool reset3;
	private bool reset4;
	private bool reset5;
	public float spike1position;
	public float spike2position;
	public float spike3position;
	public float spike4position;
	public float spike5position;
	private float increment;
	private bool phase1;
	private bool phase2;
	private bool phase3;
	public GameObject pause;
	public GameObject victory;
	public GameObject defeat;
	private bool defeated;
	public GUIText hp;
	private int health;
	public static GameObject s1;
	public static GameObject s2;
	public static GameObject s3;
	public static GameObject s4;
	public static GameObject s5;
	public static GameObject s21;
	public static GameObject s22;
	public static GameObject s23;
	public static GameObject s24;
	public static bool plat1hit;
	public static bool plat2hit;
	public static bool plat3hit;
	public static bool plat4hit;
	public static bool plat5hit;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject [] walls;
	public GameObject switch1;
	public GameObject switch2;
	public GameObject switch3;
	public GameObject switch4;
	public static bool switcher1;
	public static bool switcher2;
	public static bool switcher3;
	public static bool switcher4;
	public GameObject [] walls2;
	private bool keepcounting;
	private int counter;
	public GUIText count;
	public GameObject [] fallingobjects;
	public GameObject boss_die;
	public GameObject [] water;
	private bool waterhit;
	public GameObject top;
	public GameObject bar1;
	public GameObject bar2;
	public GameObject bar3;
	public GameObject bar4;
	public GameObject stage3;
	public GameObject whitespot1;
	public GameObject whitespot2;
	public GameObject whitespot3;
	public static GameObject spot1;
	public static GameObject spot2;
	public static GameObject spot3;
	public static bool spothit1;
	public static bool spothit2;
	public static bool spothit3;
	private bool complete;
	private GameObject[] boss;
	public GameObject victoryscreen;


	// Use this for initialization
	void Start () {
		sound.instance.boss();
		phase1 = false;
		plat1hit = false;
		plat2hit = false;
		plat3hit = false;
		plat4hit = false;
		plat5hit = false;
		phase2 = false;
		phase3 = false;
		complete = false;
		reset1 = false;
		reset2 = false;
		reset3 = false;
		reset4 = false;
		reset5 = false;
		wall1on = false;
		wall2on = false;
		wall3on = false;
		wall4on = false;
		wall5on = false;
		defeated = false;
		health = 100;
		increment = 0.1f;
		s1 = platform1;
		s2 = platform2;
		s3 = platform3;
		s4 = platform4;
		s5 = platform5;
		switcher1 = false;
		switcher2 = false;
		switcher3 = false;
		switcher4 = false;
		spothit1 = false;
		spothit2 = false;
		spothit3 = false;
		keepcounting = false;
		counter = 8;
		boss = GameObject.FindGameObjectsWithTag("boss");
		waterhit = false;
		count.fontSize = (Screen.width)/27;
		count.text = "";
		hp.fontSize = (Screen.width)/27;

		spike1x = spike1.transform.position.x;
		spike2y = spike2.transform.position.y;
		spike3y = spike3.transform.position.y;
		spike4y = spike4.transform.position.y;
		spike5x = spike5.transform.position.x;

		spikey1 = spike1.transform.position;
		spikey2 = spike2.transform.position;
		spikey3 = spike3.transform.position;
		spikey4 = spike4.transform.position;
		spikey5 = spike5.transform.position;

		dmg1 = dmgspike1.transform.position;
		dmg2 = dmgspike2.transform.position;
		dmg3 = dmgspike3.transform.position;
		dmg4 = dmgspike4.transform.position;
		dmg5 = dmgspike5.transform.position;

		switch1.GetComponent<Animator>().SetBool("off",true);
		switch2.GetComponent<Animator>().SetBool("off",true);
		switch3.GetComponent<Animator>().SetBool("off",true);
		switch4.GetComponent<Animator>().SetBool("off",true);

		s21 = bar1;
		s22 = bar2;
		s23 = bar3;
		s24 = bar4;

		spot1 = whitespot1;
		spot2 = whitespot2;
		spot3 = whitespot3;
	
	}
	public static void Checkspots(GameObject spots){
		if(spots == spot1){
			spothit1 = true;
		}
		if(spots == spot2){
			spothit2 = true;
		}
		if(spots == spot3){
			spothit3 = true;
		}
	}
	public static void CheckSwitch(GameObject switcher){
		
		if(switcher == s21){
			
			switcher1 = true;
		}
		if(switcher == s22){
			switcher2 = true;
		}
		if(switcher == s23){
			switcher3 = true;
		}
		if(switcher == s24){
			switcher4 = true;
		}
	}

	public static void CheckPlatform(GameObject platform){

		if(platform == s1){
			plat1hit = true;
		}
		if(platform == s2){
			plat2hit = true;
		}
		if(platform == s3){
			plat3hit = true;
		}
		if(platform == s4){
			plat4hit = true;
		}
		if(platform == s5){
			plat5hit = true;
		}

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		if(!phase1){

			if((plat1hit)&&
				(!wall1on)){
				sound.instance.cactuswalls();
				wall1on = true;
				wall1.GetComponent<Animator>().SetBool("off",true);
				platform1.SetActive(false);
				block1.GetComponent<Collider2D>().enabled = true;
				
			}
			if((plat2hit)&&
				(!wall2on)){
				sound.instance.cactuswalls();
				wall2on = true;
				wall2.GetComponent<Animator>().SetBool("off",true);
				platform2.SetActive(false);
				block2.GetComponent<Collider2D>().enabled = true;
			}
			if((plat3hit)&&
				(!wall3on)){
				sound.instance.cactuswalls();
				wall3on = true;
				wall3.GetComponent<Animator>().SetBool("off",true);
				platform3.SetActive(false);
				block3.GetComponent<Collider2D>().enabled = true;
			}
			if((plat4hit)&&
				(!wall4on)){
				sound.instance.cactuswalls();
				wall4on = true;
				wall4.GetComponent<Animator>().SetBool("off",true);
				platform4.SetActive(false);
				block4.GetComponent<Collider2D>().enabled = true;
			}
			if((plat5hit)&&
				(!wall5on)){
				sound.instance.cactuswalls();
				wall5on = true;
				wall5.GetComponent<Animator>().SetBool("off",true);
				platform5.SetActive(false);
				block5.GetComponent<Collider2D>().enabled = true;
			}

			if((spike1.transform.position.x <= -10)&&
				(!reset1)){
				spike1.transform.position = new Vector3(spikey1.x,spikey1.y,spikey1.z);
			}
			if((spike2.transform.position.y >= 7)&&
				(!reset2)){
				spike2.transform.position = new Vector3(spikey2.x,spikey2.y,spikey2.z);
			}
			if((spike3.transform.position.y >= 7)&&
				(!reset3)){
				spike3.transform.position = new Vector3(spikey3.x,spikey3.y,spikey3.z);
			}
			if((spike4.transform.position.y >= 7)&&
				(!reset4)){
				spike4.transform.position = new Vector3(spikey4.x,spikey4.y,spikey4.z);
			}
			if((spike5.transform.position.x >= 10)&&
				(!reset5)){
				spike5.transform.position = new Vector3(spikey5.x,spikey5.y,spikey5.z);
			}

			if((!dmgspike1.activeSelf)&&
				(!reset1)&&
				(spike1.activeSelf)){
				spike1x = spike1.transform.position.x;
				spike1.transform.position = new Vector3(spike1x-increment,spikey1.y,
					spikey1.z);
			}
			else if((!reset1)&&(dmgexplode1.activeSelf)){
				reset1 = true;
				spike1.SetActive(true);
				spike1.transform.position = new Vector3(spikey1.x,spikey1.y,spikey1.z);
			}
			if((!dmgspike2.activeSelf)&&
				(!reset2)&&
				(spike2.activeSelf)){
				spike2y = spike2.transform.position.y;
				spike2.transform.position = new Vector3(spikey2.x,spike2y+increment,
					spikey2.z);
			}
			else if((!reset2)&&(dmgexplode2.activeSelf)){
				reset2 = true;
				spike2.SetActive(true);
				spike2.transform.position = new Vector3(spikey2.x,spikey2.y,spikey2.z);
			}
			if((!dmgspike3.activeSelf)&&
				(!reset3)&&
				(spike3.activeSelf)){
				spike3y = spike3.transform.position.y;
				spike3.transform.position = new Vector3(spikey3.x,spike3y+increment,
					spikey3.z);
			}
			else if((!reset3)&&(dmgexplode3.activeSelf)){
				reset3 = true;
				spike3.SetActive(true);
				spike3.transform.position = new Vector3(spikey3.x,spikey3.y,spikey3.z);
			}
			if((!dmgspike4.activeSelf)&&
				(!reset4)&&
				(spike4.activeSelf)){
				spike4y = spike4.transform.position.y;
				spike4.transform.position = new Vector3(spikey4.x,spike4y+increment,
					spikey4.z);
			}
			else if((!reset4)&&(dmgexplode4.activeSelf)){
				reset4 = true;
				spike4.SetActive(true);
				spike4.transform.position = new Vector3(spikey4.x,spikey4.y,spikey4.z);
			}
			if((!dmgspike5.activeSelf)&&
				(!reset5)&&
				(spike5.activeSelf)){
				spike5x = spike5.transform.position.x;
				spike5.transform.position = new Vector3(spike5x+increment,spikey5.y,
					spikey5.z);
			}
			else if((!reset5)&&(dmgexplode5.activeSelf)){
				reset5 = true;
				spike5.SetActive(true);
				spike5.transform.position = new Vector3(spikey5.x,spikey5.y,spikey5.z);
			}

			if((wall1on)&&
				(spike1.transform.position.x >= spike1position-0.5)&&
				(spike1.transform.position.x <= spike1position+0.5)){
				spike1.SetActive(false);
				dmgspike1.SetActive(true);
			}
			if((dmgspike1.activeSelf)){
				temp1 = dmgspike1.transform.position.x;
				dmgspike1.transform.position = new Vector3(temp1+increment,dmg1.y,dmg1.z);
			}
			if(dmgspike1.transform.position.x >= spikey1.x){
				dmgspike1.transform.position = new Vector3(dmg1.x,dmg1.y,dmg1.z);
				dmgspike1.SetActive(false);
				dmgexplode1.SetActive(true);
				sound.instance.bubbledmg();
				StartCoroutine(decreasehealth(10));
			}
			if((wall2on)&&
				(spike2.transform.position.y >= spike2position-0.5)&&
				(spike2.transform.position.y <= spike2position+0.5)){
				spike2.SetActive(false);
				dmgspike2.SetActive(true);
			}
			if((dmgspike2.activeSelf)){
				temp2 = dmgspike2.transform.position.y;
				dmgspike2.transform.position = new Vector3(dmg2.x,temp2-increment,dmg2.z);
			}
			if(dmgspike2.transform.position.y <= spikey2.y){
				dmgspike2.transform.position = new Vector3(dmg2.x,dmg2.y,dmg2.z);
				dmgspike2.SetActive(false);
				dmgexplode2.SetActive(true);
				sound.instance.bubbledmg();
				StartCoroutine(decreasehealth(10));
			}
			if((wall3on)&&
				(spike3.transform.position.y >= spike3position-0.5)&&
				(spike3.transform.position.y <= spike3position+0.5)){
				spike3.SetActive(false);
				dmgspike3.SetActive(true);
			}
			if((dmgspike3.activeSelf)){
				temp3 = dmgspike3.transform.position.y;
				dmgspike3.transform.position = new Vector3(dmg3.x,temp3-increment,dmg3.z);
			}
			if(dmgspike3.transform.position.y <= spikey3.y){
				dmgspike3.transform.position = new Vector3(dmg3.x,dmg3.y,dmg3.z);
				dmgspike3.SetActive(false);
				dmgexplode3.SetActive(true);
				sound.instance.bubbledmg();
				StartCoroutine(decreasehealth(10));
			}
			if((wall4on)&&
				(spike4.transform.position.y >= spike4position-0.5)&&
				(spike4.transform.position.y <= spike4position+0.5)){
				spike4.SetActive(false);
				dmgspike4.SetActive(true);
			}
			if((dmgspike4.activeSelf)){
				temp4 = dmgspike4.transform.position.y;
				dmgspike4.transform.position = new Vector3(dmg4.x,temp4-increment,dmg4.z);
			}
			if(dmgspike4.transform.position.y <= spikey4.y){
				dmgspike4.transform.position = new Vector3(dmg4.x,dmg4.y,dmg4.z);
				dmgspike4.SetActive(false);
				dmgexplode4.SetActive(true);
				sound.instance.bubbledmg();
				StartCoroutine(decreasehealth(10));
			}
			if((wall5on)&&
				(spike5.transform.position.x >= spike5position-0.5)&&
				(spike5.transform.position.x <= spike5position+0.5)){
				spike5.SetActive(false);
				dmgspike5.SetActive(true);
			}
			if((dmgspike5.activeSelf)){
				temp5 = dmgspike5.transform.position.x;
				dmgspike5.transform.position = new Vector3(temp5-increment,dmg5.y,dmg5.z);
			}
			if(dmgspike5.transform.position.x <= spikey5.x){
				dmgspike5.transform.position = new Vector3(dmg5.x,dmg5.y,dmg5.z);
				dmgspike5.SetActive(false);
				dmgexplode5.SetActive(true);
				sound.instance.bubbledmg();
				StartCoroutine(decreasehealth(10));
			}

		}

		if((!phase1)&&
			(health == 50)){
			sound.instance.ballswap();
			wall5.GetComponent<Animator>().SetBool("off",false);
			block5.GetComponent<Collider2D>().enabled = false;
			wall1.GetComponent<Animator>().SetBool("off",false);
			block1.GetComponent<Collider2D>().enabled = false;
			wall2.GetComponent<Animator>().SetBool("off",false);
			block2.GetComponent<Collider2D>().enabled = false;
			wall3.GetComponent<Animator>().SetBool("off",false);
			block3.GetComponent<Collider2D>().enabled = false;
			wall4.GetComponent<Animator>().SetBool("off",false);
			block4.GetComponent<Collider2D>().enabled = false;
			for(int i=0;i<walls.Length;i++){
				walls[i].SetActive(false);
			}
			for(int i=0;i<walls2.Length;i++){
				walls2[i].SetActive(true);
			}
			switch1.GetComponent<Animator>().SetBool("off",false);
			switch2.GetComponent<Animator>().SetBool("off",false);
			switch3.GetComponent<Animator>().SetBool("off",false);
			switch4.GetComponent<Animator>().SetBool("off",false);
			
			phase1 = true;
			keepcounting = true;
			StartCoroutine("counting");
			
		}
		if((switcher1)&&
			(!switch1.GetComponent<Animator>().GetBool("switch"))&&
			(phase1)){
			sound.instance.starswitch();
			switch1.GetComponent<Animator>().SetBool("switch",true);
		}
		if((switcher2)&&
			(!switch2.GetComponent<Animator>().GetBool("switch"))&&
			(phase1)){
			sound.instance.starswitch();
			switch2.GetComponent<Animator>().SetBool("switch",true);
		}
		if((switcher3)&&
			(!switch3.GetComponent<Animator>().GetBool("switch"))&&
			(phase1)){
			sound.instance.starswitch();
			switch3.GetComponent<Animator>().SetBool("switch",true);
		}
		if((switcher4)&&
			(!switch4.GetComponent<Animator>().GetBool("switch"))&&
			(phase1)){
			sound.instance.starswitch();
			switch4.GetComponent<Animator>().SetBool("switch",true);
		}
		if((phase1)&&
			(!phase2)&&
			(switcher1)&&
			(switcher2)&&
			(switcher3)&&
			(switcher4)){
			
			phase2= true;
			keepcounting = false;
			count.text = "";
			StartCoroutine("turnoffphase2");

		}
		if((phase2)&&
			(!waterhit)){
			for(int i=0;i<water.Length;i++){
				if(!water[i].activeSelf){
					waterhit = true;
					sound.instance.fallingwater();
					StartCoroutine(decreasehealth(25));
					top.GetComponent<Collider2D>().enabled = true;
					break;
				}
			}
		}
		if((phase2)&&
			(health==25)&&
			(!phase3)&&
			(!stage3.activeSelf)){
			count.text = "";
			sound.instance.ballswap();
			stage3.SetActive(true);
		}
		if((spothit1)){
			if((!whitespot1.GetComponent<Animator>().GetBool("turnoff"))){
				whitespot1.GetComponent<Animator>().SetBool("turnoff",true);
				sound.instance.swaplamp();
				whitespot1.GetComponent<Collider2D>().enabled = false;
			}	
		}
		if((spothit2)){
			if((!whitespot2.GetComponent<Animator>().GetBool("turnoff"))){
				whitespot2.GetComponent<Animator>().SetBool("turnoff",true);
				sound.instance.swaplamp();
				whitespot2.GetComponent<Collider2D>().enabled = false;
			}	
		}
		if((spothit3)){
			if((!whitespot3.GetComponent<Animator>().GetBool("turnoff"))){
				whitespot3.GetComponent<Animator>().SetBool("turnoff",true);
				sound.instance.swaplamp();
				whitespot3.GetComponent<Collider2D>().enabled = false;
			}	
		}
		if((spothit1)&&
			(spothit2)&&
			(spothit3)&&
			(!phase3)){
			phase3 = true;
			count.text = "";
			waterhit = false;
			spothit1 = false;
			spothit2 = false;
			spothit3 = false;
			StartCoroutine("turnoffphase3");

		}
		if((phase3)&&
			(!waterhit)){
			for(int i=0;i<water.Length;i++){
				if(!water[i].activeSelf){
					waterhit = true;
					StartCoroutine(decreasehealth(25));
					sound.instance.fallingwater();
					top.GetComponent<Collider2D>().enabled = true;
					break;
				}
			}
		}
	
	}
	void Update(){

		if((!complete)&&
			(health == 0)){
			complete = true;
			victory.SetActive(true);
			for(int i =0;i<boss.Length;i++){
				boss[i].SetActive(false);
			}
			sound.instance.cactusdie();
			boss_die.SetActive(true);
		}

		if((defeat.activeSelf)||
			(pause.activeSelf)||
			(victoryscreen.activeSelf)){
			hp.text = "";
		}
		else{
			hp.text = "The Cactus: "+health+"%";
		}

		if((defeat.activeSelf)&&
			(!defeated)){
			
		defeated = true;
		phase1 = false;
		plat1hit = false;
		plat2hit = false;
		plat3hit = false;
		plat4hit = false;
		plat5hit = false;
		phase2 = false;
		phase3 = false;
		reset1 = false;
		reset2 = false;
		reset3 = false;
		reset4 = false;
		reset5 = false;
		wall1on = false;
		wall2on = false;
		wall3on = false;
		wall4on = false;
		wall5on = false;
		defeated = false;
		spothit1 = false;
		spothit2 = false;
		spothit3 = false;
		complete = false;
		health = 100;
		increment = 0.1f;
		s1 = platform1;
		s2 = platform2;
		s3 = platform3;
		s4 = platform4;
		s5 = platform5;
		switcher1 = false;
		switcher2 = false;
		switcher3 = false;
		switcher4 = false;
		wall1.GetComponent<Animator>().SetBool("off",false);
		platform1.SetActive(true);
		block1.GetComponent<Collider2D>().enabled = false;
		wall2.GetComponent<Animator>().SetBool("off",false);
		platform2.SetActive(true);
		block2.GetComponent<Collider2D>().enabled = false;
		wall3.GetComponent<Animator>().SetBool("off",false);
		platform3.SetActive(true);
		block3.GetComponent<Collider2D>().enabled = false;
		wall4.GetComponent<Animator>().SetBool("off",false);
		platform4.SetActive(true);
		block4.GetComponent<Collider2D>().enabled = false;
		wall5.GetComponent<Animator>().SetBool("off",false);
		platform5.SetActive(true);
		block5.GetComponent<Collider2D>().enabled = false;
		dmgexplode1.SetActive(false);
		dmgexplode2.SetActive(false);
		dmgexplode3.SetActive(false);
		dmgexplode4.SetActive(false);
		dmgexplode5.SetActive(false);
		keepcounting = false;
		counter = 8;
		count.text = "";
		for(int i=0;i<walls.Length;i++){
			walls[i].SetActive(true);
		}
		for(int i=0;i<walls2.Length;i++){
				walls2[i].SetActive(false);
		}
		
		waterhit = false;
		top.GetComponent<Collider2D>().enabled = true;
		switch1.GetComponent<Animator>().SetBool("off",true);
		switch2.GetComponent<Animator>().SetBool("off",true);
		switch3.GetComponent<Animator>().SetBool("off",true);
		switch4.GetComponent<Animator>().SetBool("off",true);
		switch1.GetComponent<Animator>().SetBool("switch",false);
		switch2.GetComponent<Animator>().SetBool("switch",false);
		switch3.GetComponent<Animator>().SetBool("switch",false);
		switch4.GetComponent<Animator>().SetBool("switch",false);
		switch1.GetComponent<Animator>().SetBool("turnoff",false);
		switch2.GetComponent<Animator>().SetBool("turnoff",false);
		switch3.GetComponent<Animator>().SetBool("turnoff",false);
		switch4.GetComponent<Animator>().SetBool("turnoff",false);
		if(stage3.activeSelf){
			whitespot3.GetComponent<Animator>().SetBool("turnoff",false);
			whitespot3.GetComponent<Animator>().SetBool("turnoff",false);
			whitespot3.GetComponent<Animator>().SetBool("turnoff",false);
			whitespot1.GetComponent<Collider2D>().enabled = true;
			whitespot1.GetComponent<Collider2D>().enabled = true;
			whitespot1.GetComponent<Collider2D>().enabled = true;
		}
		stage3.SetActive(false);
	}
		if((!defeat.activeSelf)&&
			(defeated)){
			defeated = false;
			count.text = "";
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
	IEnumerator counting(){
		while(keepcounting){
			count.text= counter + "...";
			if(defeat.activeSelf){
				count.text = "";
			}
			yield return new WaitForSeconds(1);
			counter--;
			if(counter == 0){
				top.GetComponent<Collider2D>().enabled = false;
				for(int i=0;i<fallingobjects.Length;i++){
					fallingobjects[i].GetComponent<Rigidbody2D>().isKinematic = false;
				}
				counter = 8;
			}	
			count.text= counter + "...";
			if(defeat.activeSelf){
				count.text = "";
			}
			
		}
	}
	IEnumerator turnoffphase2(){
		yield return new WaitForSeconds(1);
		for(int i=0;i<walls2.Length;i++){
				walls2[i].SetActive(false);
			}
			top.GetComponent<Collider2D>().enabled = false;
			for(int i=0;i<water.Length;i++){
				water[i].GetComponent<Rigidbody2D>().isKinematic = false;
			}
			switch1.GetComponent<Animator>().SetBool("off",true);
			switch2.GetComponent<Animator>().SetBool("off",true);
			switch3.GetComponent<Animator>().SetBool("off",true);
			switch4.GetComponent<Animator>().SetBool("off",true);
			switch1.GetComponent<Animator>().SetBool("switch",false);
			switch2.GetComponent<Animator>().SetBool("switch",false);
			switch3.GetComponent<Animator>().SetBool("switch",false);
			switch4.GetComponent<Animator>().SetBool("switch",false);
			switch1.GetComponent<Animator>().SetBool("turnoff",false);
			switch2.GetComponent<Animator>().SetBool("turnoff",false);
			switch3.GetComponent<Animator>().SetBool("turnoff",false);
			switch4.GetComponent<Animator>().SetBool("turnoff",false);
			phase2 = true;
	}
	IEnumerator turnoffphase3(){
		yield return new WaitForSeconds(1);
		stage3.SetActive(false);
		top.GetComponent<Collider2D>().enabled = false;
			for(int i=0;i<water.Length;i++){
				water[i].GetComponent<Rigidbody2D>().isKinematic = false;
			}

	}
}
