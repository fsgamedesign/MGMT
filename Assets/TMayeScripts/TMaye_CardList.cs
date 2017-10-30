using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMaye_CardList : MonoBehaviour {

    // Developer Name: Trevor Maye
    // Contribution: Creation of spawn loactions for decks 1-4
    // Feature: Spawn Points
    // Start & End dates:10/11/2017-10/12/2017
    // References: N/A
    // Links: N/A

    public Transform SpawnLocation1;
    public Transform SpawnLocation2;
    public Transform SpawnLocation3;
    public Transform SpawnLocation4;
    public List<GameObject> myCardList = new List<GameObject>();
    //public GameObject FakeDeck;
    

    void Start()
    {

    }

    void Update()
    {
        //FakeDeck.transform.localScale = new Vector3(1, (0.057f * myCardList.Count), 1.368334f);

        if(myCardList.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(myCardList[0], SpawnLocation1);
                myCardList.RemoveAt(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(myCardList[0], SpawnLocation2);
                myCardList.RemoveAt(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(myCardList[0], SpawnLocation3);
                myCardList.RemoveAt(0);
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(myCardList[0], SpawnLocation4);
                myCardList.RemoveAt(0);
            }
        }
        
        
    }

}
