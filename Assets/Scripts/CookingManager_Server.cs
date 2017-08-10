using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager_Server : MonoBehaviour {

    public GameObject SoupPlate;
    public bool SoupIsDelivered;

	void Start () {
		
	}
	
	void Update () {
		if (SoupIsDelivered == true)
        {
            //SoupPlate.SetActive(false);
            Destroy(SoupPlate);
            //Increase Score
        }
	}
    private void OnTriggerEnter(Collider coll)
    {

        if (Input.GetKey(KeyCode.O) && coll.CompareTag("SoupPlate"))
        {
            SoupIsDelivered = true;
        }
        if (Input.GetKey(KeyCode.E) && coll.CompareTag("SoupPlate"))
        {
            SoupIsDelivered = true;
        }

    }
}
