using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    
    
    public void ChangeScore(int WaterValue)
    {
        score += WaterValue;
        text.text = "X " + score.ToString();
        
    }

    void Update()
    {
        if (score >= 10)
        {
            YouWin();
        }
    }

    void YouWin()
    {
        text.text = "YOU WIN!";
        Time.timeScale = 0f;
    }
}
