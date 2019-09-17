using UnityEngine;
using System.Collections;

public class blackboxes : MonoBehaviour {

	private Rigidbody2D rb;
	private Collider2D coll;
	private Vector3 originalposition;
	public Animator box;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D>();
		coll = GetComponent<Collider2D>();
		originalposition = transform.position;

	
	}
	IEnumerator turnoff(){
		yield return new WaitForSeconds(1);
		coll.enabled = false;
		rb.isKinematic = true;
		transform.position = new Vector3(originalposition.x,originalposition.y,originalposition.z);
		transform.rotation = Quaternion.Euler(0,0,45);
		coll.enabled = true;
		box.SetBool("turnoff",false);
	}
	// Update is called once per frame
	void OnCollisionEnter2D(Collision2D other){

		if((other.gameObject.tag == "platform")||
			(other.gameObject.tag =="boss")){

			box.SetBool("turnoff",true);
			StartCoroutine("turnoff");

		}

	}
}