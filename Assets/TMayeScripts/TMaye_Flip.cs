using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMaye_Flip : MonoBehaviour {

    // Developer Name: Trevor Maye
    // Contribution: Double clicking to flip the cards
    // Feature: Flipping Cards
    // Start & End dates: 10/8/2017-10/8/2017
    // References: N/A
    // Links: N/A

    bool MCStarted = false;
    int MouseClicks = 0;
    float MouseTimer = .25f;

    private void OnMouseDown()
    {
        MouseClicks++;
        if (MCStarted)
        {
            return;
        }
        MCStarted = true;
        Invoke("checkMouseDoubleClick", MouseTimer);
    }

    void checkMouseDoubleClick()
    {
        if(MouseClicks > 1)
        {
            transform.Rotate(0, 0, 180);
        }
        else
        {
    
        }
        MCStarted = false;
        MouseClicks = 0;
    }
}
