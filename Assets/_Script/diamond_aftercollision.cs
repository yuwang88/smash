﻿using UnityEngine;
using System.Collections;

public class diamond_aftercollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		transform.rigidbody.useGravity = true;
		rigidbody.AddForce (new Vector3(0,0,2),ForceMode.VelocityChange);
	}
}
