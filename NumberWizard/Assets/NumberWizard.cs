using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int max = 1000;
        int min = 1;
      
        Debug.Log("Welcome to Number Wizard you shit");
        Debug.Log("Pick a number ");
        Debug.Log("The highest number you can pick is " + max);
        Debug.Log("Lowest Number is " + min);
        Debug.Log("Press up for higher, press down for lower , Enter for correct!!");
    
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("You pressed up");
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("You pressed down");
        }
        else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You pressed enter");
        }
       
	}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
}
