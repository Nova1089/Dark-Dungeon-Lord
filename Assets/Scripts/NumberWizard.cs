using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
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
            Debug.Log("Told you I was a wizard.");
            StartGame();
        }
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("I am the number wizard.");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct.");
        max = max + 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is your number..." + guess);
    }
}