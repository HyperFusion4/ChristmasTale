using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coin : MonoBehaviour {
    public int coinCount = 0;
    public Text CoinCounter;

    void Start()
    {
        CoinCounter.GetComponent<Text>().text = "Coin: " + coinCount;  
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "coin")
        {
            coinCount++;
            CoinCounter.GetComponent<Text>().text = "Coin: " + coinCount;
            Destroy(collision.gameObject);
        }
    }
}
