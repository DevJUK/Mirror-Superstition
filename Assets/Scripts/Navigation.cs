using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour
{

    public void ChangeToGame()
    {
        SceneManager.LoadScene(1);
    }

public void ChangeToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChangeToWinner()
    {
        SceneManager.LoadScene(2);
    }

}
