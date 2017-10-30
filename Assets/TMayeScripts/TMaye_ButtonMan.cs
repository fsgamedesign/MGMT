using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TMaye_ButtonMan : MonoBehaviour {

    // Developer Name: Trevor Maye
    // Contribution: Reload Button and Exit Game button
    // Feature: The UI Buttons
    // Start & End dates: 10/8/2017-10/9/2017
    // References: N/A
    // Links: N/A

    // Developer Name: Enrique Villarreal
    // Contribution: Reset Board, Cut, Shuffle, Top, Shuffle Together
    // Feature: The UI Buttons
    // Start & End dates: 10/16/2017 - 10/16/2017
    // References: N/A
    // Links: N/A

    public GameObject deck;
    public GameObject CutButton;
    public GameObject TButton;
    public GameObject SButton;

    public GameObject[] Cards;

    public void Start()
    {
        TButton.SetActive(false);
        SButton.SetActive(false);
    }
    public void RelodButton(string ResetBoard)
    {
        SceneManager.LoadScene(ResetBoard);
    }
    public void ExitB()
    {
        Application.Quit();
    }
    public void ResetBoard()
    {
        Cards = GameObject.FindGameObjectsWithTag("Card");
        foreach(GameObject card in Cards)
        {
            card.GetComponent<Card>().CardRetrunB();
        }
        if(deck.GetComponent<MainDeck>().half != null)
        {
            deck.GetComponent<MainDeck>().BottomOnTop();
            CutButton.SetActive(true);
            SButton.SetActive(false);
            TButton.SetActive(false);
        }
    }
    public void Shuffle()
    {
        deck.GetComponent<MainDeck>().Shuffle();
    }
    public void Cut()
    {
        CutButton.SetActive(false);
        SButton.SetActive(true);
        TButton.SetActive(true);
        deck.GetComponent<MainDeck>().CutTheDeck();
    }
    public void Top()
    {
        CutButton.SetActive(true);
        SButton.SetActive(false);
        TButton.SetActive(false);
        deck.GetComponent<MainDeck>().BottomOnTop();
    }
    public void ShuffleTogether()
    {
        CutButton.SetActive(true);
        SButton.SetActive(false);
        TButton.SetActive(false);
        deck.GetComponent<MainDeck>().STogether();
    }

}
