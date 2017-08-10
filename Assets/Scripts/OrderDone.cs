using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderDone : MonoBehaviour {

    public GameObject scoreText;
    public bool PlateDone;
    public KeyCode DropButton;

	
	void Start () {
		
	}
	
	
	void Update () {
		if (PlateDone == true) {
            Debug.Log("Score Increase");
            //Increase Score Text
        }
	}

	void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.tag== "FinishedPlate")
        {
            Debug.Log("Collision detected");
            //if (Input.GetKeyDown(DropButton))
           // {
                Debug.Log("Plate has been dropped");
                PlateDone = true;
            //}
        }
    }
}
