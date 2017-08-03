using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick_UP_test_Omar : MonoBehaviour {

	public Transform player;
	public Transform player2;
	bool hasPlayer = false;
	bool hasPlayer2 = false;// checks if player is in range
	//bool beingCarried = false; // check if object is being carried currently 

	//private bool touched = false;
	public bool dropped = true;


	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {

		float dis = Vector3.Distance (gameObject.transform.position, player.transform.position);
		float dis2 = Vector3.Distance (gameObject.transform.position, player2.transform.position);

		if (dis <= 1.0f) {
			hasPlayer = true;
		} else {
			hasPlayer = false;
		}
		if (hasPlayer && Input.GetKeyDown (KeyCode.E) && dropped) {
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.parent = player;
			transform.position = player.position;
			dropped = false;

		} else if (Input.GetKeyDown (KeyCode.E) && !dropped) {
			GetComponent<Rigidbody> ().isKinematic = false;
			transform.parent = null;
			dropped = true;

		} 


		if (dis2 <= 1.0f) {
			hasPlayer2 = true;
		} else {
			hasPlayer2 = false;
		}
		if (hasPlayer2 && Input.GetKeyDown (KeyCode.O) && dropped) {
			GetComponent<Rigidbody> ().isKinematic = true;
			transform.parent = player2;
			transform.position = player2.position;
			dropped = false;

		} else if (Input.GetKeyDown (KeyCode.O) && !dropped) {
			GetComponent<Rigidbody> ().isKinematic = false;
			transform.parent = null;
			dropped = true;

		} 
	}
}
