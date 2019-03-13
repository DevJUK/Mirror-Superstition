using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimerScrpt : MonoBehaviour
{
    public int Score;
    public int Multiplyer;

    public float Timer;
    public float TimerTarget;
    public bool TimerRunning;

    public GameObject TimerTxtBox;
    public Text TimerTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > TimerTarget && TimerRunning)
        {
            Timer -= Time.deltaTime;
        }
        else if (Timer <= TimerTarget && TimerRunning)
        {
            TimerRunning = false;
        }
        TimerTxt.text = Timer.ToString("#.00");
    }

    public void RestartTimer()
    {
        Timer = 0;
        TimerRunning = true;
    }
}
