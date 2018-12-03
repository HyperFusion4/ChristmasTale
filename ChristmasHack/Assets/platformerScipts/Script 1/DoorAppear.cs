using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAppear : MonoBehaviour {

    public GameObject Door;

    void OnTriggerEnter2D(Collider2D other)
    {
        Door.SetActive(true);  
    }
}
