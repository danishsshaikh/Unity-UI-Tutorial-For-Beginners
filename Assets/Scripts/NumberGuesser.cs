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
        NextGuess();
        //badaNum = badaNum + 1;
    }

    public void OnPressHigh()
    {
        chotaNum = guess + 1 ;
        NextGuess();
    }

    public void OnPressLow()
    {
        badaNum = guess - 1;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(chotaNum, badaNum);
        guessText.text = guess.ToString();
    }
}
