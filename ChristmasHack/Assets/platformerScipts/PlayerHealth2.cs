using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth2 : MonoBehaviour {


	public int health = 10;
    public Slider HpBar;
    public Text HpText;
    int lives = 3;
    public int Exp = 0;
    public int level = 1;
    public Slider ExpBar;
    public Text ExpText;

	void Start () {
        //PlayerPrefs.SetInt("Lives", lives);
        lives = PlayerPrefs.GetInt("Lives");
        HpBar.GetComponent<Slider>().value = health;
        ExpBar.GetComponent<Slider>().value = Exp;
        HpBar.GetComponent<Text>().text = "Health: " + health;
    }
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
            //reload the level
            PlayerPrefs.SetInt("Lives", lives - 1);
			Scene scene = SceneManager.GetActiveScene();
			SceneManager.LoadScene (scene.name);
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Death")
        {
            health -= 3;
        }
        float yVelocity = GetComponent<Rigidbody2D>().velocity.y;
		if (collision.gameObject.tag == "Baddie" && yVelocity >= 0) {
			health -= 1;
		}else if (collision.gameObject.tag == "Baddie" && yVelocity < 0)
        {
            Destroy(collision.gameObject);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 300));
        }
	}
}
