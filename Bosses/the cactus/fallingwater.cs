using UnityEngine;
using System.Collections;

public class fallingwater : MonoBehaviour {

	public static GameObject s1;
	public static GameObject s2;
	public static GameObject s3;
	public static GameObject s4;
	public static GameObject s5;
	public static GameObject s6;
	public static GameObject s7;
	public static GameObject s8;
	public static GameObject s9;
	public static GameObject s10;
	public static bool hit1;
	public static bool hit2;
	public static bool hit3;
	public static bool hit4;
	public static bool hit5;
	public static bool hit6;
	public static bool hit7;
	public static bool hit8;
	public static bool hit9;
	public static bool hit10;
	public GameObject block1;
	public GameObject block2;
	public GameObject block3;
	public GameObject block4;
	public GameObject block5;
	public GameObject block6;
	public GameObject block7;
	public GameObject block8;
	public GameObject block9;
	public GameObject block10;
	public GameObject explode1;
	public GameObject explode2;
	public GameObject explode3;
	public GameObject explode4;
	public GameObject explode5;
	public GameObject explode6;
	public GameObject explode7;
	public GameObject explode8;
	public GameObject explode9;
	public GameObject explode10;
	public GameObject defeat;
	private bool defeated;
	private bool complete1;
	private bool complete2;
	private bool complete3;
	private bool complete4;
	private bool complete5;
	private bool complete6;
	private bool complete7;
	private bool complete8;
	private bool complete9;
	private bool complete10;
	private Vector3 position1;
	private Vector3 position2;
	private Vector3 position3;
	private Vector3 position4;
	private Vector3 position5;
	private Vector3 position6;
	private Vector3 position7;
	private Vector3 position8;
	private Vector3 position9;
	private Vector3 position10;
	private static bool plat1;
	private static bool plat2;
	private static bool plat3;
	private static bool plat4;
	private static bool plat5;
	private static bool plat6;
	private static bool plat7;
	private static bool plat8;
	private static bool plat9;
	private static bool plat10;



	// Use this for initialization
	void Start () {

		s1 = block1;
		s2 = block2;
		s3 = block3;
		s4 = block4;
		s5 = block5;
		s6 = block6;
		s7 = block7;
		s8 = block8;
		s9 = block9;
		s10 = block10;
		hit1 = false;
		hit2 = false;
		hit3 = false;
		hit4 = false;
		hit5 = false;
		hit6 = false;
		hit7 = false;
		hit8 = false;
		hit9 = false;
		hit10 = false;
		complete1 = false;
		complete2 =false;
		complete3 = false;
		complete4 = false;
		complete5 = false;
		complete6 = false;
		complete7 = false;
		complete8 = false;
		complete9 = false;
		complete10 = false;
		plat1 = false;
		plat2 = false;
		plat3 = false;
		plat4 = false;
		plat5 = false;
		plat6 = false;
		plat7 = false;
		plat8 = false;
		plat9= false;
		plat10 = false;
		position1 = block1.transform.position;
		position2 = block2.transform.position;
		position3 = block3.transform.position;
		position4 = block4.transform.position;
		position5 = block5.transform.position;
		position6 = block6.transform.position;
		position7 = block7.transform.position;
		position8 = block8.transform.position;
		position9 = block9.transform.position;
		position10 = block10.transform.position;

	
	}
	public static void returnplatform(GameObject temp){

		if(temp == s1){
			plat1 = true;
		}
		if(temp == s2){
			plat2 = true;
		}
		if(temp == s3){
			plat3 = true;
		}
		if(temp == s4){
			plat4 = true;
		}
		if(temp == s5){
			plat5 = true;
		}
		if(temp == s6){
			plat6 = true;
		}
		if(temp == s7){
			plat7 = true;
		}
		if(temp == s8){
			plat8 = true;
		}
		if(temp == s9){
			plat9 = true;
		}
		if(temp == s10){
			plat10 = true;
		}

	}

	public static void returnObject(GameObject temp){
		
		if(temp == s1){
			hit1 = true;
		}
		if(temp == s2){
			hit2 = true;
		}
		if(temp == s3){
			hit3 = true;
		}
		if(temp == s4){
			hit4 = true;
		}
		if(temp == s5){
			hit5 = true;
		}
		if(temp == s6){
			hit6 = true;
		}
		if(temp == s7){
			hit7 = true;
		}
		if(temp == s8){
			hit8 = true;
		}
		if(temp == s9){
			hit9 = true;
		}
		if(temp == s10){
			hit10 = true;
		}

	}
	IEnumerator resetbox(GameObject block){
		yield return new WaitForSeconds(1);

		if(block == block1){
			block1.transform.position = new Vector3(position1.x,position1.y,position1.z);
			block1.transform.rotation = Quaternion.identity;
			block1.SetActive(true);
			explode1.SetActive(false);
			hit1 = false;
			complete1 = false;
		}
		if(block == block2){
			block2.transform.position = new Vector3(position2.x,position2.y,position2.z);
			block2.transform.rotation = Quaternion.identity;
			block2.SetActive(true);
			explode2.SetActive(false);
			hit2 = false;
			complete2 = false;
		}
		if(block == block3){
			block3.transform.position = new Vector3(position3.x,position3.y,position3.z);
			block3.transform.rotation = Quaternion.identity;
			block3.SetActive(true);
			explode3.SetActive(false);
			hit3 = false;
			complete3 = false;
		}
		if(block == block4){
			block4.transform.position = new Vector3(position4.x,position4.y,position4.z);
			block4.transform.rotation = Quaternion.identity;
			block4.SetActive(true);
			explode4.SetActive(false);
			hit4 = false;
			complete4 = false;
		}
		if(block == block5){
			block5.transform.position = new Vector3(position5.x,position5.y,position5.z);
			block5.transform.rotation = Quaternion.identity;
			block5.SetActive(true);
			explode5.SetActive(false);
			hit5 = false;
			complete5 = false;
		}
		if(block == block6){
			block6.transform.position = new Vector3(position6.x,position6.y,position6.z);
			block6.transform.rotation = Quaternion.identity;
			block6.SetActive(true);
			explode6.SetActive(false);
			hit6 = false;
			complete6 = false;
		}
		if(block == block7){
			block7.transform.position = new Vector3(position7.x,position7.y,position7.z);
			block7.transform.rotation = Quaternion.identity;
			block7.SetActive(true);
			explode7.SetActive(false);
			hit7 = false;
			complete7 = false;
		}
		if(block == block8){
			block8.transform.position = new Vector3(position8.x,position8.y,position8.z);
			block8.transform.rotation = Quaternion.identity;
			block8.SetActive(true);
			explode8.SetActive(false);
			hit8 = false;
			complete8 = false;
		}
		if(block == block9){
			block9.transform.position = new Vector3(position9.x,position9.y,position9.z);
			block9.transform.rotation = Quaternion.identity;
			block9.SetActive(true);
			explode9.SetActive(false);
			hit9 = false;
			complete9 = false;
		}
		if(block == block10){
			block10.transform.position = new Vector3(position10.x,position10.y,position10.z);
			block10.transform.rotation = Quaternion.identity;
			block10.SetActive(true);
			explode10.SetActive(false);
			hit10 = false;
			complete10 = false;
		}
	}
	IEnumerator resetplat(GameObject block){
		yield return null;

		if(block == block1){
			block1.transform.position = new Vector3(position1.x,position1.y,position1.z);
			block1.transform.rotation = Quaternion.identity;
			block1.SetActive(true);
			explode1.SetActive(false);
			hit1 = false;
			complete1 = false;
			plat1 = false;
		}
		if(block == block2){
			block2.transform.position = new Vector3(position2.x,position2.y,position2.z);
			block2.transform.rotation = Quaternion.identity;
			block2.SetActive(true);
			explode2.SetActive(false);
			hit2 = false;
			complete2 = false;
			plat2 = false;
		}
		if(block == block3){
			block3.transform.position = new Vector3(position3.x,position3.y,position3.z);
			block3.transform.rotation = Quaternion.identity;
			block3.SetActive(true);
			explode3.SetActive(false);
			hit3 = false;
			complete3 = false;
			plat3 = false;
		}
		if(block == block4){
			block4.transform.position = new Vector3(position4.x,position4.y,position4.z);
			block4.transform.rotation = Quaternion.identity;
			block4.SetActive(true);
			explode4.SetActive(false);
			hit4 = false;
			complete4 = false;
			plat4 = false;
		}
		if(block == block5){
			block5.transform.position = new Vector3(position5.x,position5.y,position5.z);
			block5.transform.rotation = Quaternion.identity;
			block5.SetActive(true);
			explode5.SetActive(false);
			hit5 = false;
			complete5 = false;
			plat5 = false;
		}
		if(block == block6){
			block6.transform.position = new Vector3(position6.x,position6.y,position6.z);
			block6.transform.rotation = Quaternion.identity;
			block6.SetActive(true);
			explode6.SetActive(false);
			hit6 = false;
			complete6 = false;
			plat6 = false;
		}
		if(block == block7){
			block7.transform.position = new Vector3(position7.x,position7.y,position7.z);
			block7.transform.rotation = Quaternion.identity;
			block7.SetActive(true);
			explode7.SetActive(false);
			hit7 = false;
			complete7 = false;
			plat7 = false;
		}
		if(block == block8){
			block8.transform.position = new Vector3(position8.x,position8.y,position8.z);
			block8.transform.rotation = Quaternion.identity;
			block8.SetActive(true);
			explode8.SetActive(false);
			hit8 = false;
			complete8 = false;
			plat8 = false;
		}
		if(block == block9){
			block9.transform.position = new Vector3(position9.x,position9.y,position9.z);
			block9.transform.rotation = Quaternion.identity;
			block9.SetActive(true);
			explode9.SetActive(false);
			hit9 = false;
			complete9 = false;
			plat9 = false;
		}
		if(block == block10){
			block10.transform.position = new Vector3(position10.x,position10.y,position10.z);
			block10.transform.rotation = Quaternion.identity;
			block10.SetActive(true);
			explode10.SetActive(false);
			hit10 = false;
			complete10 = false;
			plat10 = false;
		}
	}

	
	// Update is called once per frame
	void Update () {

		if((hit1)&&
			(!complete1)){
			block1.GetComponent<Rigidbody2D>().isKinematic = true;
			block1.SetActive(false);
			complete1= true;
			explode1.SetActive(true);
			StartCoroutine(resetbox(block1));
		}
		if((hit2)&&
			(!complete2)){
			block2.GetComponent<Rigidbody2D>().isKinematic = true;
			block2.SetActive(false);
			complete2= true;
			explode2.SetActive(true);
			StartCoroutine(resetbox(block2));
		}
		if((hit3)&&
			(!complete3)){
			block3.GetComponent<Rigidbody2D>().isKinematic = true;
			block3.SetActive(false);
			complete3= true;
			explode3.SetActive(true);
			StartCoroutine(resetbox(block3));
		}
		if((hit4)&&
			(!complete4)){
			block4.GetComponent<Rigidbody2D>().isKinematic = true;
			block4.SetActive(false);
			complete4= true;
			explode4.SetActive(true);
			StartCoroutine(resetbox(block4));
		}
		if((hit5)&&
			(!complete5)){
			block5.GetComponent<Rigidbody2D>().isKinematic = true;
			block5.SetActive(false);
			complete5= true;
			explode5.SetActive(true);
			StartCoroutine(resetbox(block5));
		}
		if((hit6)&&
			(!complete6)){
			block6.GetComponent<Rigidbody2D>().isKinematic = true;
			block6.SetActive(false);
			complete6= true;
			explode6.SetActive(true);
			StartCoroutine(resetbox(block6));
		}
		if((hit7)&&
			(!complete7)){
			block7.GetComponent<Rigidbody2D>().isKinematic = true;
			block7.SetActive(false);
			complete7= true;
			explode7.SetActive(true);
			StartCoroutine(resetbox(block7));
		}
		if((hit8)&&
			(!complete8)){
			block8.GetComponent<Rigidbody2D>().isKinematic = true;
			block8.SetActive(false);
			complete8= true;
			explode8.SetActive(true);
			StartCoroutine(resetbox(block8));
		}
		if((hit9)&&
			(!complete9)){
			block9.GetComponent<Rigidbody2D>().isKinematic = true;
			block9.SetActive(false);
			complete9= true;
			explode9.SetActive(true);
			StartCoroutine(resetbox(block9));
		}
		if((hit10)&&
			(!complete10)){
			block10.GetComponent<Rigidbody2D>().isKinematic = true;
			block10.SetActive(false);
			complete10= true;
			explode10.SetActive(true);
			StartCoroutine(resetbox(block10));
		}
		if((plat1)&&
			(!complete1)){
			block1.SetActive(false);
			complete1= true;
			StartCoroutine(resetplat(block1));
		}
		if((plat2)&&
			(!complete2)){
			block2.SetActive(false);
			complete2= true;
			StartCoroutine(resetplat(block2));
		}
		if((plat2)&&
			(!complete2)){
			block2.SetActive(false);
			complete2= true;
			StartCoroutine(resetplat(block2));
		}
		if((plat3)&&
			(!complete3)){
			block3.SetActive(false);
			complete3= true;
			StartCoroutine(resetplat(block3));
		}
		if((plat4)&&
			(!complete4)){
			block4.SetActive(false);
			complete4= true;
			StartCoroutine(resetplat(block4));
		}
		if((plat5)&&
			(!complete5)){
			block5.SetActive(false);
			complete5= true;
			StartCoroutine(resetplat(block5));
		}
		if((plat6)&&
			(!complete6)){
			block6.SetActive(false);
			complete6= true;
			StartCoroutine(resetplat(block6));
		}
		if((plat7)&&
			(!complete7)){
			block7.SetActive(false);
			complete7= true;
			StartCoroutine(resetplat(block7));
		}
		if((plat8)&&
			(!complete8)){
			block8.SetActive(false);
			complete8= true;
			StartCoroutine(resetplat(block8));
		}
		if((plat9)&&
			(!complete9)){
			block9.SetActive(false);
			complete9= true;
			StartCoroutine(resetplat(block9));
		}
		if((plat10)&&
			(!complete10)){
			block10.SetActive(false);
			complete10= true;
			StartCoroutine(resetplat(block10));
		}
		if((defeat.activeSelf)&&
			(!defeated)){

			StartCoroutine(resetplat(block1));
			StartCoroutine(resetplat(block2));
			StartCoroutine(resetplat(block3));
			StartCoroutine(resetplat(block4));
			StartCoroutine(resetplat(block5));
			StartCoroutine(resetplat(block6));
			StartCoroutine(resetplat(block7));
			StartCoroutine(resetplat(block8));
			StartCoroutine(resetplat(block9));
			StartCoroutine(resetplat(block10));
			defeated = true;

		}
		if((!defeat.activeSelf)&&
			(defeated))
		defeated= false;
	}
}
