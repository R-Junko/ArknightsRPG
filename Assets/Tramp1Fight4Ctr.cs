﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tramp1Fight4Ctr : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Translate(Vector2.up * 400 * 1 * Time.deltaTime, Space.World);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
