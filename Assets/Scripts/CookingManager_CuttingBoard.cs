using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager_CuttingBoard : MonoBehaviour
{

    public bool OnionOnCuttingBoard;
    public GameObject FullOnion;
    public GameObject CutOnionSource;
    public GameObject SpawnedOnion;
    public Transform CutOnionSpawn;




    void Start()
    {

    }

    void Update()
    {
        if ((OnionOnCuttingBoard == true) && Input.GetKeyUp(KeyCode.E))
        {
            //activate the cutting animation **Or should we link the animation call directly to the player?**
            FullOnion.SetActive(false);
            //CutOnion.SetActive(true);
            SpawnedOnion = Instantiate(CutOnionSource, CutOnionSpawn.position, transform.rotation) as GameObject;
            OnionOnCuttingBoard = false;
        }
        if ((OnionOnCuttingBoard == true) && Input.GetKeyUp(KeyCode.O))
        {
            //activate the cutting animation **Or should we link the animation call directly to the player?**
            FullOnion.SetActive(false);
            //CutOnion.SetActive(true);
            SpawnedOnion = Instantiate(CutOnionSource, CutOnionSpawn.position, transform.rotation) as GameObject;
            OnionOnCuttingBoard = false;
        }
    }
    private void OnTriggerStay(Collider coll)
    {
       
        if (Input.GetKey(KeyCode.O) && coll.CompareTag("FullOnion"))
        {
            OnionOnCuttingBoard = true;
        }
        if (Input.GetKey(KeyCode.E) && coll.CompareTag("FullOnion"))
        {
            OnionOnCuttingBoard = true;
        }

    }
}

