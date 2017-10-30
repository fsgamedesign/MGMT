using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurningCard : MonoBehaviour {

    // Developer Name: Tyrese Millender
    // Contribution: Turning Cards
    // Feature: Turning Cards
    // Start & End dates: Oct 2- Oct 18
    // References: N/A
    // Links: N/A

    // Use this for initialization
    public void Turnable() {
		//Debug.Log ("Turnable TurnedMe this function was called on" + name);
		gameObject.transform.Rotate(90, 0, 0);
	}

	public void Normal()
	{
		Debug.Log ("Normal TurnedMe this function was called on" + name);
		gameObject.transform.Rotate(0, 0, 0);
	}
}
