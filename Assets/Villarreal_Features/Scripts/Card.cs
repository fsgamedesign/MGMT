using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour {

    // Developer Name: Enrique Villarreal
    // Contribution: Returning Cards to the deck
    // Feature: Returning cards to the deck
    // Start & End dates: 10/9/2017 - 10/18/2017
    // References: N/A
    // Links: N/A

    public GameObject Deck;
    public GameObject CardS;

    string cName; 

	// Use this for initialization
	void Start ()
    {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }

    public void CardRetrunB()
    {
        string[] x = gameObject.name.Split('(');
        
        Deck.GetComponent<MainDeck>().CardRB(x[0]);
        Destroy(gameObject, 0.2f);
    }

    public void CardReturnT()
    {
        string[] x = gameObject.name.Split('(');

        Deck.GetComponent<MainDeck>().CardRT(x[0]);
        Destroy(gameObject, 0.2f);
    }

    public void ChangeParent(GameObject deck)
    {
        gameObject.transform.parent = deck.transform;
        Deck = gameObject.transform.parent.gameObject;
        gameObject.transform.localScale = new Vector3(1, 1, 1);
    }
    public void NoParent()
    {
        gameObject.transform.parent = null;
    }
}
