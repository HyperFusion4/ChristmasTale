using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionMode : MonoBehaviour {
    public void MenuReturn()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Coinless1()
    {
        SceneManager.LoadScene("Level1(CL)");
    }
    public void Coinless2()
    {
        SceneManager.LoadScene("Level2(CL)");
    }
    public void Coinless3()
    {
        SceneManager.LoadScene("Level3(CL)");
    }
    public void Coinless4()
    {
        SceneManager.LoadScene("Level4(CL)");
    }
    public void Coinless5()
    {
        SceneManager.LoadScene("Level5(CL)");
    }
}

