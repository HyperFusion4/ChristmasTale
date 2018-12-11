using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {
    public Text Character;
    public int cac = 0;
    public void Hero()
    {
        Character.GetComponent<Text>().text = "Hero";
    }

    public void Riba()
    {
        Character.GetComponent<Text>().text = "Riba";
    }

    public void Frost()
    {
        Character.GetComponent<Text>().text = "Frost";
    }

    public void Villain()
    {
        Character.GetComponent<Text>().text = "Villain";
    }

}
