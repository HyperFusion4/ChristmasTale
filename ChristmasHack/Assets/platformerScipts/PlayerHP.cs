using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {
    public int hp = 5;
    public int exp = 0;
    public Text Health;
    public Slider HealthBar;
    public Slider ExpBar;
    public int coinCount = 0;
    public Text Coins;
    public int liveCount = 3;
    public Text Lives;
    public GameObject Prefab;
    public int Levels = 1;
    public Text level;

    void Start()
    {
        //PlayerPrefs.SetInt("Lives", liveCount);
        //PlayerPrefs.SetInt("CandyCane", coinCount);
        //PlayerPrefs.SetInt("Level", Levels);
        //PlayerPrefs.SetInt("Exp", exp);
        liveCount = PlayerPrefs.GetInt("Lives");
        coinCount = PlayerPrefs.GetInt("CandyCane");
        Levels = PlayerPrefs.GetInt("Level");
        exp = PlayerPrefs.GetInt("Exp");
        Health.GetComponent<Text>().text = "Health: " + hp;
        HealthBar.GetComponent<Slider>().value = hp;
        ExpBar.GetComponent<Slider>().value = exp;
        Coins.GetComponent<Text>().text = "Coins: " + coinCount;
        Lives.GetComponent<Text>().text = "Lives: " + liveCount;
        level.GetComponent<Text>().text = "Level:" + Levels;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.collider.gameObject.tag);
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
        if (collision.gameObject.tag == "Enemy" && collision.otherCollider.gameObject.tag == "Player" && yVelocity >= 0)
        {
            hp--;
            Health.GetComponent<Text>().text = "Health: " + hp;
            HealthBar.GetComponent<Slider>().value = hp;

            if (hp <= 0)
            {
                //reload the level
                PlayerPrefs.SetInt("Lives", liveCount - 1);
                Lives.GetComponent<Text>().text = "Lives: " + liveCount;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
              if (liveCount <= 0)
                {
                    SceneManager.LoadScene("Lose");
                }
            }
        } else if (collision.gameObject.tag == "Enemy" && yVelocity < 0)
        {
            exp++;
            ExpBar.GetComponent<Slider>().value = exp;
            Destroy(collision.gameObject);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600));
            Instantiate(Prefab, collision.gameObject.transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("Exp", exp);
            if (exp >= 10)
            {
                exp = 0;
                PlayerPrefs.SetInt("Exp", exp);
                Levels++;
                PlayerPrefs.SetInt("Level", Levels + 1);
                ExpBar.GetComponent<Slider>().value = exp;
                level.GetComponent<Text>().text = "Level: " + Levels;
            }
            
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCount++;
            Coins.GetComponent<Text>().text = "Coins: " + coinCount;
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("CandyCane", coinCount + 1);
        }
        if (collision.gameObject.tag == "Lives")
        {
            liveCount++;
            Lives.GetComponent<Text>().text = "Lives: " + liveCount;
            Destroy(collision.gameObject);
            PlayerPrefs.SetInt("Lives", liveCount + 1);
        }
    }








}
