﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
	public Text text;
	float currentTime = 1f;
	float startingTime = 6f;
   
	
	[SerializeField] Text countdownText;
	
	// Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString ("0");
		
		if (currentTime <= 0)
		{
			currentTime = 0;
			YouLose();
		}
    }
	void YouLose()
	{
		text.text = "YOU LOSE!";
		Time.timeScale = 0f;
	}

}
