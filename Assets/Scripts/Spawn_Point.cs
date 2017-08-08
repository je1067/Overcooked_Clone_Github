using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Point : MonoBehaviour {

	public GameObject objectToSpawn;
	GameObject spawnedObject;
	public Transform player;
	public Transform player2;
	public bool canSpawn;
	public bool canSpawn2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (player.position, transform.position) < 6f) {



			if (Input.GetKeyDown (KeyCode.E) && canSpawn) {

				spawnedObject = Instantiate (objectToSpawn, player.position, transform.rotation) as GameObject;
				canSpawn = false;
				spawnedObject.transform.parent = player.transform;
				spawnedObject.GetComponent<Rigidbody> ().isKinematic = true;
				spawnedObject.GetComponent<Pick_UP_test_Omar> ().dropped = false;


			}
		} else if (Vector3.Distance (player.position, transform.position) > 5f) {
			canSpawn = true;
		}


		if (Vector3.Distance (player2.position, transform.position) < 6f) {



			if (Input.GetKeyDown (KeyCode.O) && canSpawn2) {

				spawnedObject = Instantiate (objectToSpawn, player2.position, transform.rotation) as GameObject;
				canSpawn = false;
				spawnedObject.transform.parent = player2.transform;
				spawnedObject.GetComponent<Rigidbody> ().isKinematic = true;
				spawnedObject.GetComponent<Pick_UP_test_Omar> ().dropped2 = false;


			}
		} else if (Vector3.Distance (player2.position, transform.position) > 5f) {
			canSpawn2 = true;
		}

		
	}
}
