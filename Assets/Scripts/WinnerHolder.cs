using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerHolder : MonoBehaviour
{
	public bool RedWin;
	public bool BlueWin;
	public bool GreenWin;

	private void Awake()
	{
		if (FindObjectsOfType<WinnerHolder>().Length > 1)
		{
			Destroy(FindObjectsOfType<WinnerHolder>()[1].gameObject, .1f);
		}

		DontDestroyOnLoad(this);
	}
}
