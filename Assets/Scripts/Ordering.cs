using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ordering : MonoBehaviour {

    public GameObject orderText1;
    public GameObject orderText2;
    public GameObject orderText3;

    public GameObject dishWasher;
    public GameObject finishedMeal;

    public float orderTime = 0.0f;
    public float orderStart = 0.0f;
    public float orderTime2 = 0.0f;
    public float generalTime = 0.0f;


	void Start () {
        orderText1.SetActive(false);
	}
	
	
	void FixedUpdate () {

        //Start the counter that determines whether or not an order gets processed
        orderStart += Time.deltaTime;
        //Timer to figure out how between orders
        if (orderStart > 2.0f)
        {
            //probability of a new order
            float randomNumber = Random.Range(0.0f, 1.0f);
            if (randomNumber > 0.9f)
            {
                //sets the first order active and starts the order timer
                orderText1.SetActive(true);
                orderTime += Time.deltaTime;

                // time until order expires, resets timers
                if (orderTime > 3.0f)
                {
                    orderText1.SetActive(false);
                    orderTime = 0.0f;
                    orderStart = 0.0f;
                }
                if (orderTime > 1.0f)
                {
                    orderTime2 += Time.deltaTime;
                    orderText2.SetActive(true);

                    if (orderTime2 > 3.0f)
                    {
                        orderTime2 = 0.0f;
                        orderText2.SetActive(false);
                    }
                }
                
            }  
        } else
        {
            generalTime += Time.deltaTime;
        }
        


	}
}
