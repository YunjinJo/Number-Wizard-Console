using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard.");
        Debug.Log("Pick a Number");
        Debug.Log("Highest numer is: " + max);
        Debug.Log("Lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500.");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Higher");
            min = guess;
            NextGuess();
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Lower");
            max = guess;
            NextGuess();
            Debug.Log(guess);
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Correct");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
    }
}
