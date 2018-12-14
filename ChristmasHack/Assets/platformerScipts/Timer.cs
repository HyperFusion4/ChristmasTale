using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
    public float timer = 300;
    public Text TimerText;
	// Use this for initialization
	void Start () {
        TimerText.GetComponent<Text>().text = "Time" + timer;
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
	}
}
