using UnityEngine;
using System.Collections;

public class screens_scale_transform : MonoBehaviour {

	 private float cameralength  = 0.525f;
	 private GameObject maincam;


	// Use this for initialization
	void Start () {

		maincam = GameObject.FindGameObjectWithTag("MainCamera").gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 newscale = transform.localScale;
		newscale.x = (cameralength)*(Camera.main.aspect);
		transform.localScale = newscale;

		transform.position = new Vector3(maincam.transform.position.x,maincam.transform.position.y,transform.position.z);
	
	}
}
