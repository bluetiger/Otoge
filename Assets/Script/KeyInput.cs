using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour {

    public GameObject gameObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.Z);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.X);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.C);
        }
        else if(Input.GetKeyDown(KeyCode.V))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.V);
        }
        else if(Input.GetKeyDown(KeyCode.B))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.B);
        }
        else if(Input.GetKeyDown(KeyCode.N))
        {
            gameObject.GetComponent<MainScript>().KeyDown(KeyCode.N);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();   
        }
    }
}
