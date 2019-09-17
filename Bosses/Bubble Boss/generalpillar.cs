using UnityEngine;
using System.Collections;

public class generalpillar : MonoBehaviour {

	public static int hp = 100;

	// Use this for initialization
	void Start () {

		hp = 100;
	
	}

	public static int reducehp(int damage){

		hp = hp - damage;

		return hp;

	}

	public static int currenthp(){

		return hp;

	}

	public static int resethp(){
		hp = 100;
		return hp;
	}

	
	// Update is called once per frame
	void Update () {

	
	}
}
