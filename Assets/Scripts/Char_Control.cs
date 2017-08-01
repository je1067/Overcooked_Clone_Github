using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_Control : MonoBehaviour {
	CharacterController cc;

	// Use this for initialization
	void Start () {
		cc = GetComponent<CharacterController> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		float hor = Input.GetAxis ("Horizontal");
		float ver = Input.GetAxis ("Vertical");

		// Apply input 
		cc.Move(new Vector3(hor,0f,ver) * 0.5f + Physics.gravity * 0.01f);

		//looks other directions when moving 

		Vector3 movement = new Vector3 (hor,0.0f,ver);

		transform.rotation = Quaternion.LookRotation (movement);

		transform.Translate (movement * Time.deltaTime, Space.World);

			//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		//transform.rotation = Quaternion.LookRotation(movement);


		//transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);



		
	}
}
