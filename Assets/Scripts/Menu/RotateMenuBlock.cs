﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMenuBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15 * Time.deltaTime, 0, 0));
	}
}
