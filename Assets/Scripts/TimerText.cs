using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour {
    public Text timeLeftText;
    public GameObject gameOverText;
    public string timeText;
    public float timeLeft = 60.0f;
    
    

	void Start () {
		
	}
	
	void Update () {
        timeLeft -= Time.deltaTime;

        //timeText = (timeLeft);

        timeLeftText.text = (timeLeft.ToString("F0"));
        if (timeLeft <= 0.0f){
            // timeLeftText.SetActive(false);
            timeLeft = 0.0f;
            gameOverText.SetActive(true);
        }
	}
}
