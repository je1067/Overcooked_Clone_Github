using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Point : MonoBehaviour {


	// ADD TIMER 
	public GameObject objectToSpawn;
	GameObject spawnedObject;
	public Transform player;
	public Transform player2;
	public Players_Move play1, play2;
	public bool canSpawn;
	public bool canSpawn2;
	public bool alreadyHolding = false;
	float cooldown = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		cooldown += Time.deltaTime;

		if (Vector3.Distance (player.position, transform.position) < 0.5f) {



			if (Input.GetKeyDown (KeyCode.E) && canSpawn && cooldown >= 1f && !alreadyHolding) {

				spawnedObject = Instantiate (objectToSpawn, player.position, transform.rotation) as GameObject;
				canSpawn = false;
				spawnedObject.transform.parent = player.transform;
				spawnedObject.GetComponent<Rigidbody> ().isKinematic = true;
				spawnedObject.GetComponent<Pick_UP_test_Omar> ().dropped = false;
				cooldown = 0;


			}
		} else if (Vector3.Distance (player.position, transform.position) > 1.5f) {
			canSpawn = true;
		}


		if (Vector3.Distance (player2.position, transform.position) < 0.5f) {



			if (Input.GetKeyDown (KeyCode.O) && canSpawn2 && cooldown >= 1f && !alreadyHolding) {

				spawnedObject = Instantiate (objectToSpawn, player2.position, transform.rotation) as GameObject;
				canSpawn2 = false;
				spawnedObject.transform.parent = player2.transform;
				spawnedObject.GetComponent<Rigidbody> ().isKinematic = true;
				spawnedObject.GetComponent<Pick_UP_test_Omar> ().dropped2 = false;
				cooldown = 0;


			}
		} else if (Vector3.Distance (player2.position, transform.position) > 1.5f) {
			canSpawn2 = true;
		}

		
	}

	void OnTriggerStay(Collider col){

		alreadyHolding = true;
		
	}

	void OnTriggerExit(Collider col){
		alreadyHolding = false;
		
	}
}
