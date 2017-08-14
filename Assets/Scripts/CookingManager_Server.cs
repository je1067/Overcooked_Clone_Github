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
             //Destroy();
            //Increase Score
            Debug.Log("Soup recieved");
        }
	}
    private void OnTriggerStay(Collider coll)
    {
        if (SoupIsDelivered == false)
        {
            if (Input.GetKey(KeyCode.O) && coll.CompareTag("SoupPlate"))
            {
                SoupIsDelivered = true;
                Debug.Log("Finished Soup plate has been delivered");
                GameObject completedSoup = coll.gameObject;
                Destroy(coll.gameObject);
            }
            if (Input.GetKey(KeyCode.E) && coll.CompareTag("SoupPlate"))
            {
                SoupIsDelivered = true;
                Debug.Log("Finished Soup plate has been delivered");
                GameObject completedSoup = coll.gameObject;
                Destroy(coll.gameObject);
            }
        }
    }
}
