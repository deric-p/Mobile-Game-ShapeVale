using UnityEngine;
using System.Collections;
using Soomla.Store;

public class loadingscreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	SoomlaStore.Initialize(new ShapeValeStore());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
