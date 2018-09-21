using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallNotes : MonoBehaviour {

    public float Speed;
    // Use this for initialization
    void Start()
    {
        Vector2 direction = new Vector2(0, -1).normalized;
        GetComponent<Rigidbody2D>().velocity = direction * Speed;

    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
