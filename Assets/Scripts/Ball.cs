﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Collider2D MapArea;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(Random.value, Random.value) * 4, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		if (!rb.IsTouching(MapArea)) {
            Debug.Log("Player Died!");
        }
	}
}
