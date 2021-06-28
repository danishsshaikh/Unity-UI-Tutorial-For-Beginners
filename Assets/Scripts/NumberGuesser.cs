using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuesser : MonoBehaviour
{
    [SerializeField] int chotaNum;
    [SerializeField] int badaNum;
    [SerializeField] TextMeshProUGUI guessText;

    int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        guess = (badaNum + chotaNum) / 2;
        guessText.text = guess.ToString();
        badaNum = badaNum + 1;
    }

    public void OnPressHigh()
    {
        chotaNum = guess;
        NextGuess();
    }

    public void OnPressLow()
    {
        badaNum = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = (badaNum + chotaNum) / 2;
        guessText.text = guess.ToString();
    }
}
