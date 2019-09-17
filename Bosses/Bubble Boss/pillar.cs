using UnityEngine;
using System.Collections;

public class pillar : MonoBehaviour {


	public GameObject defeat;
	public GameObject platform;
	public Animator platformAnimator;
	public GameObject pillars;
	public Animator pillarAnimator;
	public BoxCollider2D pillaroutline;
	public Rigidbody2D pillarbody;
	public GameObject explode;
	public GUIText healthbar;
	public Vector3 position;
	private bool pillarmissing;
	private bool hitspike;
	private int hp;
	public int damage;
	private bool check;


	// Use this for initialization
	void Start () {
	hp = generalpillar.resethp();
	hp = generalpillar.currenthp();

	healthbar.fontSize = (Screen.width)/27;
	healthbar.text = "The Dark Bubble: "+hp+"%"; 
	hitspike = false;
	pillarmissing = false;
	
	}

	void OnCollisionEnter2D(Collision2D enemy) {
		if(enemy.gameObject.tag == "boss"){
			pillarAnimator.SetBool("turnon",false);
			pillarAnimator.SetBool("turnoff",true);
			pillars.SetActive(false);
			explode.SetActive(true);
			pillaroutline.enabled = false;
			pillarbody.isKinematic = true;
			platformAnimator.SetBool("turnon",false);
			platformAnimator.SetBool("turnoff",true);
			sound.instance.bubbledmg();
			StartCoroutine(decreasehealth(damage));
		}
		if(enemy.gameObject.tag == "spike"){

			pillarAnimator.SetBool("turnon",false);
			pillarAnimator.SetBool("turnoff",true);
			StartCoroutine("turnoffpillarcollider");
			platformAnimator.SetBool("turnon",false);
			platformAnimator.SetBool("turnoff",true);
			hitspike = true;

		}
	}

	IEnumerator turnoffpillarcollider(){
		yield return new WaitForSeconds(1f);
			pillaroutline.enabled = false;
			pillarbody.isKinematic = true;
	}

	IEnumerator resetPillarifHit(){
		yield return new WaitForSeconds(5f);
		transform.position = new Vector3(position.x,position.y,position.z);
		transform.rotation = Quaternion.identity;
		platformAnimator.SetBool("turnoff",false);
		platformAnimator.SetBool("turnon",true);
		pillars.SetActive(true);
		explode.SetActive(false);
		pillarAnimator.SetBool("turnoff",false);
		pillarAnimator.SetBool("turnon",true);
		pillaroutline.enabled = true;
		pillarbody.isKinematic = false;
		pillarmissing = false;

	}
	void ResetASAP(){

		transform.position = new Vector3(position.x,position.y,position.z);
		transform.rotation = Quaternion.identity;
		platformAnimator.SetBool("turnoff",false);
		platformAnimator.SetBool("turnon",true);
		pillars.SetActive(true);
		explode.SetActive(false);
		pillarAnimator.SetBool("turnoff",false);
		pillarAnimator.SetBool("turnon",true);
		pillaroutline.enabled = true;
		pillarbody.isKinematic = false;
		pillarmissing = false;

	}
	IEnumerator resetPillarifSpike(){

		yield return new WaitForSeconds(10f);
		transform.position = new Vector3(position.x,position.y,position.z);
		transform.rotation = Quaternion.identity;
		platformAnimator.SetBool("turnoff",false);
		platformAnimator.SetBool("turnon",true);
		pillaroutline.enabled = true;
		pillarbody.isKinematic = false;
		pillarAnimator.SetBool("turnoff",false);
		pillarAnimator.SetBool("turnon",true);
		hitspike = false;
		pillarmissing = false;

	}

	IEnumerator decreasehealth(int number){
	
	
		for(int i=0;i<number;i++){
			if(hp == 0){
				break;
			}
			if(defeat.activeSelf){
				break;
			}
			yield return new WaitForSeconds(0.05f);
			hp = generalpillar.reducehp(1);
			if(defeat.activeSelf){
				hp = generalpillar.resethp();
				i = number;
				break;
			}

			}
			


	}
	
	// Update is called once per frame
	void Update () {

	hp = generalpillar.currenthp();

	healthbar.text = "The Dark Bubble: "+hp+"%"; 

	if(defeat.activeSelf){

		hp = generalpillar.resethp();
		ResetASAP();

	}
	if((hitspike == true)&&
		(!pillarmissing)){
		pillarmissing = true;
		StartCoroutine("resetPillarifSpike");
	}
	if((explode.activeSelf)&&
		(!pillarmissing)){
		pillarmissing = true;
		StartCoroutine("resetPillarifHit");
	}
	
	}
}
