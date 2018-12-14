using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToLevel3 : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Level3");
    }
}
