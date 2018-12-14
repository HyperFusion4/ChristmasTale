using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinLess : MonoBehaviour {
    public int coinCount = 0;
    public Text Coins;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

}
