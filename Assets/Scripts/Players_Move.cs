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

	public float coolDownLimit = 1.5f;
	void Start () {
		//cc = GetComponent<CharacterController> ();
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate () {
		coolDown += Time.deltaTime;
		int horMove = 0;
		int verMove = 0;




		if (Input.GetKey(KeyCode.D)) {
			//verMove = 1;
			horMove = 1;
		}else if (Input.GetKey(KeyCode.A)) {
			//verMove = -1;
			horMove = -1;
		}
		if (Input.GetKey(KeyCode.W)) {
			//horMove = 1;
			verMove = 1;
		}else if (Input.GetKey(KeyCode.S)) {
			//horMove = -1;
			verMove =-1;
		}

		if(Input.GetKey(KeyCode.C) && coolDown > coolDownLimit){
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


		transform.position += new Vector3 (horMove, 0f, verMove) * moveSpeed;

		Vector3 movement = new Vector3 (horMove,0.0f,verMove);

		transform.rotation = Quaternion.LookRotation (movement);

		transform.Translate (movement * Time.deltaTime, Space.World);



	}
}
