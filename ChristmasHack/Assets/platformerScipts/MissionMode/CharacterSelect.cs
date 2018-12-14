using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelect : MonoBehaviour {
    public Text Character;
    public int character = 1;
    public void Hero()
    {
        Character.GetComponent<Text>().text = "Hero";
        character = 1;
    }

    public void Riba()
    {
        Character.GetComponent<Text>().text = "Riba";
        character = 2;
    }

    public void Frost()
    {
        Character.GetComponent<Text>().text = "Frost";
        character = 3;
    }

    public void Villain()
    {
        Character.GetComponent<Text>().text = "Villain";
        character = 4;
    }

}
