using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float TimerValue = 30;
    public TMP_Text Timertxt;
    public TouchManager Tm;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TimerValue -= Time.deltaTime;
        Timertxt.text = TimerValue.ToString("00");

        if(TimerValue <= 0)
        {
            Time.timeScale = 0f;
            Tm.gameOverScreen.SetActive(true);
        }
    }
}
