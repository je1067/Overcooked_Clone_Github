using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order_Manager : MonoBehaviour {

    public GameObject order1;
    public GameObject completedOrder;
    //public bool ;
    public float orderTime;


	
	void Start () {
        order1.SetActive(false);
	}
	
	
	void Update () {
        orderTime += Time.deltaTime;

        if (orderTime > 5.0f)
        {
            order1.SetActive(true);
        } 
        if (orderTime > 15.0f)
        {
            order1.SetActive(false);
            orderTime = 0.0f;
        }
       
	}
}
