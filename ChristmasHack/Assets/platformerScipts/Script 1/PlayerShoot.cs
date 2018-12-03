using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour {

    public GameObject prefab;
    public GameObject prefab2;
    public float shootSpeed = 10;
    float timer = 0;
    public int Mp = 10;
    public int MaxMp = 10;
    public Text MpText;
    public Slider MpBar;

    // Use this for initialization
    void Start () {
        MpText.GetComponent<Text>().text = "MP: " + Mp;
        MpBar.GetComponent<Slider>().value = Mp;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > 0.3f && Mp > 0)
        {
            Mp--;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
            timer = 0;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            shootDir = shootDir * shootSpeed;
            //when calculating a vector from a to b always do destination - start position
            GameObject bullet = (GameObject)Instantiate(prefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 1.0f);

        }

        if (Input.GetButton("Fire2") && timer > 0.8f && Mp > 2)
        {
            Mp -= 3;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
            timer = 0;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            shootDir = shootDir * shootSpeed;
            //when calculating a vector from a to b always do destination - start position
            GameObject bullet = (GameObject)Instantiate(prefab2, transform.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(bullet, 1.0f);
        }

        if (Mp > MaxMp)
        {
            Mp = MaxMp;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
        }

        if (Mp < MaxMp && timer > 5.0f)
        {
            timer = 0;
            Mp++;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
        }
    }

        void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "MpStar" && Mp < MaxMp)
        {
            Mp+= 5;
            MpBar.GetComponent<Slider>().value = Mp;
            MpText.GetComponent<Text>().text = "MP: " + Mp;
            Destroy(collision.gameObject);
        }
    }
}
