using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting_Raycast : MonoBehaviour {
	public Transform paintGlob;


	
	// Update is called once per frame
	void Update () {
		// construct ray on mouse position 
		Ray ramono = Camera.main.ScreenPointToRay (Input.mousePosition);

		// reserve space in memory for ray impact info 
		RaycastHit rayHit = new RaycastHit();


		// shoot raycast 

		if(Physics.Raycast(ramono,out rayHit, 100f)){
			// do stuff with the paint glob

			//paintGlob.position = rayHit.point; // raycastHit.point = world position where the raycast hit

			//Instantiate a new paint glob clone where the ray cast hits

			Instantiate (paintGlob, rayHit.point, Quaternion.Euler (0f, 0f, 0f));

		}
		
	}
}
