using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_UP_test_Omar : MonoBehaviour {
	// NO PARENTING TO PLAYER 
	public Transform player;
	public Transform player2;
	///public Players_Move play1, play2;
	bool hasPlayer = false;
	bool hasPlayer2 = false;// checks if player is in range
	//bool beingCarried = false; // check if object is being carried currently 

	//private bool touched = false;
	public bool dropped = true;
	public bool dropped2 = true;
	public bool objectNear;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		float dis = Vector3.Distance (gameObject.transform.position, player.transform.position);
		float dis2 = Vector3.Distance (gameObject.transform.position, player2.transform.position);


		if (dis <= 0.4f) {
			hasPlayer = true;
		} else {
			hasPlayer = false;
		}
		if (hasPlayer && Input.GetKeyDown (KeyCode.E) && dropped) {
			GetComponent<Rigidbody> ().isKinematic = true;
			//play1.holding = true;
			transform.parent = player;
			transform.position = player.position;
			dropped = false;

		} else if (Input.GetKeyDown (KeyCode.E) && !dropped && !objectNear) {
			GetComponent<Rigidbody> ().isKinematic = false;
			transform.parent = null;
			dropped = true;

			//play1.holding = false;

		} 


		if (dis2 <= 0.4f) {
			hasPlayer2 = true;
		} else {
			hasPlayer2 = false;
		}
		if (hasPlayer2 && Input.GetKeyDown (KeyCode.O) && dropped2) {
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.parent = player2;
			transform.position = player2.position;
			dropped2 = false;
			//play2.holding = true;


		} else if (Input.GetKeyDown (KeyCode.O) && !dropped2  && !objectNear) {
			GetComponent<Rigidbody> ().isKinematic = false;
			transform.parent = null;
			dropped2 = true;
			//play2.holding = false;

		} 

	}
	void OnTriggerStay(Collider col){



		if(!col.CompareTag("Spawn_Point")){
			objectNear = true;
		}




	}

	void OnTriggerExit(Collider col){
		
		objectNear = false;
	}
}
