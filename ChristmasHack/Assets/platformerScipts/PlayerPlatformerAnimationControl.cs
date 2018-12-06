using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerAnimationControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Horizontal") != 0) 
        {
            int x = (int)Input.GetAxisRaw("Horizontal");
            GetComponent<Animator>().SetInteger("X", x);
            GetComponent<Animator>().SetFloat("Y", 0);
            GetComponent<Animator>().SetBool("Ground", true);
        }else
        {
            GetComponent<Animator>().SetBool("Ground", true);
            GetComponent<Animator>().SetFloat("X", 0);
            GetComponent<Animator>().SetFloat("Y", 0);
        }
	}
}
