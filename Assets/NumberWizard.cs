using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

    private int max = 1000;
    private int min = 1;
    private int guess = 500;

    // Use this for initialization
    void Start() {
        StartGame();
    }

    void StartGame () {
        Debug.Log("Number Wizard initialized");
        Debug.Log("Pick a number between "+min+" and "+max+". Keep it a secret.");
        Debug.Log("I will start guessing. Press [Up] if your number is higher, [Down] if lower.");
        Debug.Log("Is your number higher or lower than " + max/2 + "?");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Solved");
            StartGame();
        }
    }
    void NextGuess ()
    {
        guess = (max + min + 1) / 2;
        Debug.Log("Is your number higher or lower than " + guess + " ?");
    }
}