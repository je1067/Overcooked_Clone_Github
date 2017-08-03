using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roomba_Raycast : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {

		//ray cast in front of us

		// if ray cast is true turn randomly

		// else false

		// build raycast

		Ray ray = new Ray (transform.position, transform.forward);
		Debug.DrawRay (ray.origin, ray.direction * 3f, Color.yellow);

		if (Physics.Raycast (ray, 3f)) {

			float randomNum = Random.Range (0f, 100f); // random number from 0-100 
			// 50% chance to turn 
			if (randomNum < 50f) {
				transform.Rotate (0f, -90f, 0f);
			} else {
				transform.Rotate (0f, 90f, 0f);
			}
			
		} else {
			transform.Translate (0f, 0f, 5f * Time.deltaTime);


		}






	}
}
