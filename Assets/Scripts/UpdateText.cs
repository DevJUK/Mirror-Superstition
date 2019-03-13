using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{


	public ScoreTimerScrpt ScoreScript;
	public Text T;

	private void Start()
	{
		ScoreScript = FindObjectOfType<ScoreTimerScrpt>().gameObject.GetComponent<ScoreTimerScrpt>();
		T = GetComponent<Text>();
	}

	public void Update()
	{
		if (gameObject.name == "ScoreTxtOne")
		{
			UpdateP1Text();
		}
		else if (gameObject.name == "ScoreTxtTwo")
		{
			UpdateP2Text();
		}
		else if (gameObject.name == "ScoreTxtThree")
		{
			UpdateP3Text();
		}
	}

	public void UpdateP1Text()
	{
		T.text = ScoreScript.P1Score.ToString();
	}

	public void UpdateP2Text()
	{
		T.text = ScoreScript.P2Score.ToString();
	}

	public void UpdateP3Text()
	{
		T.text = ScoreScript.P3Score.ToString();
	}
}
