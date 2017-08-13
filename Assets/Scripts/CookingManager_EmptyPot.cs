using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager_EmptyPot : MonoBehaviour {

    public bool OnionInPot;
    public GameObject CutOnion;
    public GameObject FullPot;
    public GameObject EmptyPot;

    void Start () {
		
	}
	
	void Update () {
        if (OnionInPot == true)
        {
            //CutOnion.SetActive(false);
           FullPot.transform.parent.tag = "FullPot";
            EmptyPot.SetActive(false);
            FullPot.SetActive(true);
            Destroy(CutOnion);
            Debug.Log("Onion is in pot");
            // set value ++
        } else
        {
            FullPot.SetActive(false);
            EmptyPot.SetActive(true);
            

        }
    }
    private void OnTriggerStay(Collider coll)
    {
        if (OnionInPot == false)
        {
            /* if (Input.GetKey(KeyCode.E) && coll.CompareTag("CutOnionTrigger"))
             {
                 OnionInPot = true;
                 Debug.Log("Collision detected (player and Pot)");
                 GameObject cutOnion = coll.gameObject.GetComponentInChildren<Pick_UP_test_Omar>().gameObject;

                 if (cutOnion.CompareTag("CutOnion") && cutOnion != null)
                 {
                     Destroy(cutOnion);
                     Debug.Log("cutOnion has been destroyed");
                 }
             }*/
            if (Input.GetKey(KeyCode.E) && coll.CompareTag("CutOnion"))
            {
                OnionInPot = true;
                Debug.Log("Collision detected (player and Pot)");
                GameObject onionTrigger = coll.gameObject;
                Destroy(coll.gameObject);
            }
            if (Input.GetKey(KeyCode.O) && coll.CompareTag("CutOnion") )
            {
                /* OnionInPot = true;
                 Debug.Log("Collision detected (player and Pot)");
                 GameObject cutOnion = 
                     coll.gameObject.GetComponentInChildren<Pick_UP_test_Omar>().gameObject;

                 if (cutOnion.CompareTag("CutOnion") && cutOnion != null)
                 {
                     Destroy(cutOnion);
                     Debug.Log("cutOnion has been destroyed");
                 }*/
                OnionInPot = true;
                Debug.Log("Collision detected (player and Pot)");
                GameObject onionTrigger = coll.gameObject;
                Destroy(coll.gameObject);
            }
            if (Input.GetKey(KeyCode.E) && coll.CompareTag("FullOnion"))
            {
                OnionInPot = false;
                Debug.Log("Onion is not in pot");
            }
              
        }
    }
}
