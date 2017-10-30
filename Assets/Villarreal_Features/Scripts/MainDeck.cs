using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDeck : MonoBehaviour {

    // Developer Name: Enrique Villarreal
    // Contribution: Drawing cards, Shuffling the deck, Returning Cards Cutting the deck, putting the deck back into one
    // Feature: Main Deck functionality
    // Start & End dates: 10/9/2017 - 10/18/2017
    // References: N/A
    // Links: N/A

    // Developer Name: Trevor Maye
    // Contribution: Drawing cards on the markers
    // Feature: Main Deck functionality
    // Start & End dates: 10/16/2017 - 10/16/2017
    // References: N/A
    // Links: N/A

    public GameObject half;
    public GameObject CardSpawn;
    public GameObject CutSpawn;

    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;

    public GameObject DeckPrefab;

    public List<GameObject> Deck1 = new List<GameObject>();

    public List<GameObject> Deck2 = new List<GameObject>();

    public List<GameObject> TempDeck = new List<GameObject>();

    public GameObject[] Cards;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localScale = new Vector3(2.5f, (0.076f * Deck1.Count), 3.5f);
        
        
    }
    public void DrawCardT()
    {        
        GameObject temp = Instantiate(Deck1[0], CardSpawn.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[0]);
        Deck1.RemoveAt(0);
    }

    public void DrawCardB()
    {
        GameObject temp = Instantiate(Deck1[Deck1.Count - 1], CardSpawn.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[Deck1.Count - 1]);
        Deck1.RemoveAt(Deck1.Count - 1);
    }

    public void Shuffle()
    {
        for (int i = 0; i < Deck1.Count; i++)
        {
            GameObject temp = Deck1[i];
            int RandInd = Random.Range(i, Deck1.Count);
            Deck1[i] = Deck1[RandInd];
            Deck1[RandInd] = temp;
        }
    }

    public void CardRB(string card)
    {

        for (int i = 0; i < Deck2.Count; i++)
        {
            if (Deck2[i].name == card)
            {
                GameObject temp = Deck2[i];

                Deck1.Add(temp);
                Deck2.Remove(temp);
            }
        }
    }

    public void CardRT(string card)
    {
        for (int i = 0; i < Deck2.Count; i++)
        {
            if (Deck2[i].name == card)
            {
                GameObject temp = Deck2[i];

                Deck1.Insert(0, temp);
                Deck2.Remove(temp);
            }
        }
    }

    public void CutTheDeck()
    {
        half = Instantiate(DeckPrefab, CutSpawn.transform);
        half.transform.parent = null;
        for(int i = 0; i < Deck1.Count/2; i++)
        {
            half.GetComponent<MainDeck>().Deck1.Add(Deck1[i]);
        }
        Deck1.RemoveRange(0, Deck1.Count / 2);
        
    }

    public void BottomOnTop()
    {
        ChangeParentOfCards();
        for (int i = 0; i < half.GetComponent<MainDeck>().Deck1.Count; i++)
        {
            Deck1.Add(half.GetComponent<MainDeck>().Deck1[i]);
        }
        Destroy(half);
        Cards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject card in Cards)
        {
            card.GetComponent<Card>().NoParent();
        }
    }

    public void STogether()
    {
        
        ChangeParentOfCards();
        for (int i = 0; (i < half.GetComponent<MainDeck>().Deck1.Count) || (i < Deck1.Count); i++)
        {
            if(i < Deck1.Count)
            {
                TempDeck.Add(Deck1[i]);
            }
            if(i < half.GetComponent<MainDeck>().Deck1.Count)
            {
                TempDeck.Add(half.GetComponent<MainDeck>().Deck1[i]);
            }
        }
        Deck1.Clear();
        for(int i = 0; i < TempDeck.Count; i++)
        {
            Deck1.Add(TempDeck[i]);
        }
        Destroy(half);
        Invoke("ClearTemp", 1);
        Cards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject card in Cards)
        {
            card.GetComponent<Card>().NoParent();
        }
    }

    public void ChangeParentOfCards()
    {
        Cards = GameObject.FindGameObjectsWithTag("Card");
        foreach (GameObject card in Cards)
        {
            card.GetComponent<Card>().ChangeParent(gameObject);
        }
        for(int i = 0; i < half.GetComponent<MainDeck>().Deck2.Count; i++)
        {
            Deck2.Add(half.GetComponent<MainDeck>().Deck2[i]);
        }

    }

    public void ClearTemp()
    {
        TempDeck.Clear();
    }

    public void SpawnB1()
    {
        GameObject temp = Instantiate(Deck1[0], Spawn1.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[0]);
        Deck1.RemoveAt(0);
    }
    public void SpawnB2()
    {
        GameObject temp = Instantiate(Deck1[0], Spawn2.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[0]);
        Deck1.RemoveAt(0);
    }
    public void SpawnB3()
    {
        GameObject temp = Instantiate(Deck1[0], Spawn3.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[0]);
        Deck1.RemoveAt(0);
    }
    public void SpawnB4()
    {
        GameObject temp = Instantiate(Deck1[0], Spawn4.transform);
        temp.GetComponent<Card>().ChangeParent(gameObject);
        Deck2.Add(Deck1[0]);
        Deck1.RemoveAt(0);
    }




}
