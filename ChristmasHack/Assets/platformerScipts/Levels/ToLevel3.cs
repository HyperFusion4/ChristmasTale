using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class ToLevel3 : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Level3");
    }
}
