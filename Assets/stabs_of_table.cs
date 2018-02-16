﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stabs_of_table : MonoBehaviour {
    public LevelManager level;

	// Use this for initialization
	void Start () {
        level = FindObjectOfType<LevelManager>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            level.Respawn();
        }
    }
}
