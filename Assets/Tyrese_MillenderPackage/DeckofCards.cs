using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckofCards : MonoBehaviour {
	public List<GameObject> deck = new List<GameObject>();

	private List<GameObject> cards = new List<GameObject>();
	private List<GameObject> hand = new List<GameObject>();
	private int cardsDealt = 0;
	private bool showReset = false;

	void ResetDeck()
	{
		cardsDealt = -30;
		for (int i = 0; i < hand.Count; i++) {
			Destroy(hand[i]);
		}
		hand.Clear();
		cards.Clear();
		cards.AddRange(deck);
		showReset = false;
	}

	GameObject DealCard()
	{
		if (cards.Count == 0) 
		{
			showReset = true;
			return null;
		}

		int card = Random.Range (0, cards.Count - 1);
		GameObject go = GameObject.Instantiate (cards [card]) as GameObject;
		cards.RemoveAt (card);

		if (cards.Count == 0) 
		{
			showReset = true;
		}

		return go;
	}

	void Start()
	{
		ResetDeck ();
	}

	void GameOver()
	{
		cardsDealt = 0;
		for (int v = 0; v < hand.Count; v++) 
		{
			Destroy (hand [v]);
		}
		hand.Clear ();
		cards.Clear ();
		cards.AddRange (deck);
	}

	void OnGUI()
	{
		if (!showReset) 
		{
			if (GUI.Button (new Rect (10, 10, 100, 20), "Draw")) 
			{
				MoveDealtCard ();
			}
		}
	}

	void MoveDealtCard()
	{

		GameObject newCard = DealCard ();
		if (newCard == null) 
		{
			Debug.Log ("Out of Cards");
			showReset = true;
			return;
		}

		newCard.transform.position = new Vector3((float)cardsDealt / 4, (float)cardsDealt / 100, (float)cardsDealt / -50); // place card 1/4 up on all axis from last
		hand.Add(newCard); // add card to hand
		cardsDealt ++;
	}
}