using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {

        }
        else if(Input.GetKeyDown(KeyCode.C))
        {

        }
        else if(Input.GetKeyDown(KeyCode.V))
        {

        }
        else if(Input.GetKeyDown(KeyCode.B))
        {

        }
        else if(Input.GetKeyDown(KeyCode.N))
        {

        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();   
        }
    }
}
