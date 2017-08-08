using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooking_Manager : MonoBehaviour {

    public bool OnionOnCuttingBoard;
    public bool OnionInPot;
    public bool PotIsFull;
    public bool PotIsDone;
    public bool SoupDone;

    public GameObject FullOnion;
    public GameObject CutOnion;
    public GameObject EmptyPot;
    public GameObject FullPot;
    public GameObject EmptyPlate;
    public GameObject SoupPlate;

	void Start () {
		
	}
	
	void Update () {
		if (OnionOnCuttingBoard == true) {
            //activate the cutting animation **Or should we link the animation call directly to the player?**
            FullOnion.SetActive(false);
            CutOnion.SetActive(true);
        }
        if (OnionInPot == true)
        {
            CutOnion.SetActive(false);
            EmptyPot.SetActive(false);
            FullPot.SetActive(true);
            // set value ++
        }
        /*
         if (OnionsInPot == 3) {        **How are we going to count how many onions are in the pot?
            PotIsFull = true; 
        }
         */
        if (PotIsFull == true)
        {
            //Start Coroutine
            //Play timer animation
        }
        if (PotIsDone == true)
        {
            //Stop Coroutine
        }
        if (SoupDone == true)
        {
            FullPot.SetActive(false);
            EmptyPot.SetActive(true);
            EmptyPlate.SetActive(false);
            SoupPlate.SetActive(true);
        }
	}

    private void OnTriggerStay(Collider coll)
    {
        //create separate references for 
        //FullOnion detecting Cutting Board --> OnionOnCuttingBoard = true;
        //CutOnion detecting EmptyPot --> OnionsInPot = true;
        //FullPot detecting EmptyPlate --> SoupDone = true;
    }

    //Coroutine system for measuring how long the onions have been in the pot?
}
