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
    // Start is called before the first frame update
    void Start()
    {
        
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
