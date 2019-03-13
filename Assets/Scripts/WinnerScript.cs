using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerScript : MonoBehaviour
{
    public bool RedWin;
    public bool BlueWin;
    public bool GreenWin;

    public GameObject Text;
    public Text WinnerTxt;

	public WinnerHolder WinHold;

    // Start is called before the first frame update
    void Start()
    {
		WinHold = GameObject.Find("Winner").GetComponent<WinnerHolder>();

		BlueWin = WinHold.BlueWin;
		RedWin = WinHold.RedWin;
		GreenWin = WinHold.GreenWin;	
    }

    // Update is called once per frame
    void Update()
    {
        if (RedWin)
        {
            WinnerTxt.text = ("Red Player Wins");
        }
        else if (BlueWin)
        {
            WinnerTxt.text = ("Blue Player Wins");
        }
        else
        {
            WinnerTxt.text = ("Green Player Wins");
        }

    }
}
