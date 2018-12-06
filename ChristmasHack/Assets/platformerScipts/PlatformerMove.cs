using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMove : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float jumpSpeed = 1.0f;
    bool grounded = false;

    // Update is called once per frame
    void Update () {
        //Maintain Gravity
        float moveX = Input.GetAxis("Horizontal");
        int x = (int)Input.GetAxisRaw("Horizontal");
        
        GetComponent<Animator>().SetFloat("X", x);
        bool idle = (x == 0);
        GetComponent<Animator>().SetBool("Idle", idle);

        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = moveX * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = velocity;
        if (Input.GetButtonDown("Jump") && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * jumpSpeed));
        }
	}


    void OnTriggerEnter2D(Collider2D collision)
    {
     if (collision.gameObject.layer == 8)
        {
            grounded = true;
            GetComponent<Animator>().SetBool("Ground", true);
        }   
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = false;
            GetComponent<Animator>().SetBool("Ground", false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            grounded = true;
            GetComponent<Animator>().SetBool("Ground", true);
        }
    }
}
