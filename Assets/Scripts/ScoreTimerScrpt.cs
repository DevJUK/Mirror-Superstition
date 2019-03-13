using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTimerScrpt : MonoBehaviour
{
    public int P1Score;
	public int P2Score;
	public int P3Score;

	public float Timer;
    public float TimerTarget;
    public bool TimerRunning;

    public GameObject TimerTxtBox;
    public Text TimerTxt;



	private void Start()
	{
		P1Score = 0;
		P2Score = 0;
		P3Score = 0;
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
