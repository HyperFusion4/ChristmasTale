using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBottons : MonoBehaviour {

    int liveCount = 3;
    int coinCount = 0;
    public void NewGame()
    {
        PlayerPrefs.SetInt("Lives", liveCount);
        PlayerPrefs.SetInt("CandyCane", coinCount);
        SceneManager.LoadScene("Level1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void MissionMode()
    {
        SceneManager.LoadScene("MissionMode");
    }

}
