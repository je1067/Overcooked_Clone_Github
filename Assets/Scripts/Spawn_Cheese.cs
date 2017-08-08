using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Cheese : MonoBehaviour {

	public GameObject cheese;
	public Transform player;
	public bool canSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (player.position, transform.position) < 1f) {



			if (Input.GetKeyDown (KeyCode.Q) && canSpawn) {
				
				Instantiate (cheese, player.position, transform.rotation);
				canSpawn = false;
			}
		} else if (Vector3.Distance (player.position, transform.position) > 1f) {
			canSpawn = true;
		}
		
	}
}
