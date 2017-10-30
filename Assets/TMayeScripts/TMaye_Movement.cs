using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TMaye_Movement : MonoBehaviour {

    // Developer Name: Trevor Maye
    // Contribution: Creation of clicking and dragging to move cards around the table
    // Feature: Moving Cards
    // Start & End dates: 10/4/2017-10/5/2017
    // References: N/A
    // Links: N/A

    private Vector3 Spoint;
    private Vector3 set;

	// Use this for initialization
	void Start () {
        transform.parent = null;
		
	}
	
	// Update is called once per frame
	void Update () {
            
	}

    void OnMouseDown()
    {
        Spoint = Camera.main.WorldToScreenPoint(transform.position);
        set = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Spoint.z));
    }

    void OnMouseDrag()
    {
       Vector3 curSPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Spoint.z);
       Vector3 curPosition = Camera.main.ScreenToWorldPoint(curSPoint) + set;
        transform.position = curPosition + new Vector3(0, 1.5f, 0);
    }
}
