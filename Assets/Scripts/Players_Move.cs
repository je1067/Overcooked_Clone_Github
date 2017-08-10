using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players_Move : MonoBehaviour {
	//CharacterController cc;
	// Use this for initialization
	Rigidbody rb;
	public float moveSpeed = 0.25f;
	public float forceAmount = 700;
	public float coolDown = 0.0f;
	public KeyCode upKey, downKey, leftKey, rightKey, dashKey;
	public float coolDownLimit = 1.5f;
	public bool holding;


	void Start () {
		//cc = GetComponent<CharacterController> ();
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		coolDown += Time.deltaTime;
		int horMove = 0;
		int verMove = 0;




		if (Input.GetKey(rightKey)) {
			//verMove = 1;
			horMove = 1;

		}

		if (Input.GetKey(leftKey)) {
			//verMove = -1;
			horMove = -1;

		}
		if (Input.GetKey(upKey)) {
			//horMove = 1;
			verMove = 1;

		}
		if (Input.GetKey(downKey)) {
			//horMove = -1;
			verMove =-1;

		}

		// Rotation control
//		if (Input.GetKeyDown(KeyCode.D)) {
//			//verMove = 1;
//			horFace = 1;
//		}else if (Input.GetKeyDown(KeyCode.A)) {
//			//verMove = -1;
//			horFace = -1;
//		}
//		if (Input.GetKeyDown(KeyCode.W)) {
//			//horMove = 1;
//			verMove = 1;
//		}else if (Input.GetKeyDown(KeyCode.S)) {
//			//horMove = -1;
//			verMove =-1;
//		}



		if(Input.GetKey(dashKey) && coolDown > coolDownLimit){
			//rb.AddForce(rb.transform.position * Time.deltaTime * forceAmount);
			//rb.AddForce(movement * Time.deltaTime);
			rb.AddForce(transform.forward * forceAmount);
			coolDown = 0f;
		}

		//		cc.Move(new Vector3(horMove,0f,verMove) * 0.25f + Physics.gravity * 0.01f);
		//
		//
		//
		//	}


		//		if (Input.GetKey (KeyCode.I)) {
		//			//transform.position += new Vector3(0f, 0f, 1f); //differnt way to move
		//			// move with a rotation 
		//			//transform.Translate(0f,0f,moveSpeed);
		//
		//		}
		//		if (Input.GetKey (KeyCode.J)) {
		//			//transform.position += new Vector3(0f, 0f, 1f);
		//			//transform.Rotate(0f,-15f,0f);
		//			transform.Translate(-moveSpeed,0f,0f);
		//
		//		}
		//		if (Input.GetKey (KeyCode.L)) {
		//			//transform.position += new Vector3(0f, 0f, 1f);
		//			//transform.Rotate(0f,15f,0f);
		//			transform.Translate(moveSpeed,0f,0f);
		//		}
		//		if (Input.GetKey (KeyCode.K)) {
		//			//transform.position += new Vector3(0f, 0f, -1f);
		//			//transform.Translate(0f,0f,-1f);
		//			transform.Translate(0f,0f,-moveSpeed);
		//		}

		// Move player 
		Vector3 input = new Vector3 (horMove, 0f, verMove) * moveSpeed;
		//transform.position += input;
		//rb.AddForce(input * moveSpeed);
		rb.velocity = input * moveSpeed;
		//Rotation

		//Vector3 rotation = new Vector3 (horFace,0.0f,verFace);


		if(input.magnitude > 0.01f){
			transform.rotation = Quaternion.LookRotation (input);
		}


		//transform.Translate (rotation * Time.deltaTime, Space.World);



	}
}
