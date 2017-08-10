using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager_EmptyPlate : MonoBehaviour {

    public GameObject EmptyPlate;
    public GameObject SoupPlateSource;
    public GameObject SoupPlateSpawn;
    public GameObject EmptyPot;
    public GameObject FullPot;
    public CookingManager_EmptyPot emptyPotTrigger;
    public Transform SoupPlatePosition;
    public bool SoupDone;

    void Start () {
		
	}
	
	void Update () {
        if (SoupDone == true)
        {
            FullPot.SetActive(false);
            EmptyPot.SetActive(true);
            EmptyPot.transform.parent.tag = "EmptyPot";
            EmptyPlate.SetActive(false);
            //SoupPlate.SetActive(true);
            SoupPlateSpawn = Instantiate(SoupPlateSource, SoupPlatePosition.position, transform.rotation) as GameObject;
            emptyPotTrigger.OnionInPot = false;
            SoupDone = false;

        }
    }
    private void OnTriggerStay(Collider coll)
    {

        if (Input.GetKey(KeyCode.O) && coll.CompareTag("FullPot"))
        {
            SoupDone = true;
        }
        if (Input.GetKey(KeyCode.E) && coll.CompareTag("FullPot"))
        {
            SoupDone = true;
        }

    }
}
