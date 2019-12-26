using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerGameOver : MonoBehaviour
{
    int countDownStartValue = 30;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()   
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            timerUI.text = "Timer : " + spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            timerUI.text = "Timer : (o.O) !";
        }
    }
}
