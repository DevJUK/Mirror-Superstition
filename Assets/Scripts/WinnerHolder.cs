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
		DontDestroyOnLoad(this);
	}
}
