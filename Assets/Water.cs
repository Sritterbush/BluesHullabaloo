using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Water : MonoBehaviour
{
    public Text text;
    public int WaterValue = 1;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            ScoreManager.instance.ChangeScore(WaterValue);
        }
    }

    void Update()
    {
        if (WaterValue >= 10)
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
