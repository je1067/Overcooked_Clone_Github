using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Move : MonoBehaviour {


	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W)) {
			//transform.position += new Vector3(0f, 0f, 1f); //differnt way to move
			// move with a rotation 
			transform.Translate(0f,0f,1f);
		}
		if (Input.GetKey (KeyCode.A)) {
			//transform.position += new Vector3(0f, 0f, 1f);
			transform.Rotate(0f,-15f,0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			//transform.position += new Vector3(0f, 0f, 1f);
			transform.Rotate(0f,15f,0f);
		}
		if (Input.GetKey (KeyCode.S)) {
			//transform.position += new Vector3(0f, 0f, -1f);
			transform.Translate(0f,0f,-1f);
		}


	}
}
