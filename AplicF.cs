﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicF : MonoBehaviour {

    public float forca =500f;
    public Rigidbody2D bola;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
        }
		
	}
}
