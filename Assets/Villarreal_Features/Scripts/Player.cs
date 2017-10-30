using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    // Developer Name: Enrique Villarreal
    // Contribution: Drawing cards, Returning cards
    // Feature: Player interaction with deck and cards
    // Start & End dates: 10/9/2017 - 10/18/2017
    // References: N/A
    // Links: N/A


    // Developer Name: Tyrese Millinder
    // Contribution: Turning Cards
    // Feature: Player interaction with deck and cards
    // Start & End dates:10/16/2017 - 10/16/2017
    // References: N/A
    // Links: N/A
    // Use this for initialization

    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (gameObject.GetComponent<MainDeck>().Deck1.Count > 0)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                gameObject.GetComponent<MainDeck>().SpawnB1();
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                gameObject.GetComponent<MainDeck>().SpawnB2();
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                gameObject.GetComponent<MainDeck>().SpawnB3();
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                gameObject.GetComponent<MainDeck>().SpawnB4();
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //print("Work");
            Ray click = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(click, out hit, 100))
            {
                //print("Worked");
                if(hit.collider.tag == "Deck")
                {
                    //print("Working");
                    hit.collider.GetComponent<MainDeck>().DrawCardT();
                }
                
                
            }
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray click = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(click, out hit, 100))
            {
                if(hit.collider.tag == "Deck")
                {
                    hit.collider.GetComponent<MainDeck>().DrawCardB();
                }
                if(hit.collider.tag == "Card")
                {
                    hit.collider.GetComponent<TurningCard>().Turnable();
                }
               
            }
        }
        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray click = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(click, out hit, 100))
            {
                if (hit.collider.tag == "Card")
                {
                    hit.collider.GetComponent<Card>().CardRetrunB();
                }
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray click = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(click, out hit, 100))
            {
                if (hit.collider.tag == "Card")
                {
                    hit.collider.GetComponent<Card>().CardReturnT();
                }
            }
        }
    }
}
