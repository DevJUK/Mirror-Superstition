using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTimerScrpt : MonoBehaviour
{
    public int Score;
    public int Multiplyer;

    public float Timer;
    public float TimerTarget;
    public bool TimerRunning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer < TimerTarget && TimerRunning)
        {
            Timer += Time.deltaTime;
        }
        else if (Timer >= TimerTarget && TimerRunning)
        {
            TimerRunning = false;
        }
    }

    public void RestartTimer()
    {
        Timer = 0;
        TimerRunning = true;
    }
}
