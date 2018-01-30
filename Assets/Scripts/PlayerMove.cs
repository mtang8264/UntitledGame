﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
	public float speed;
	public Transform cam;
	Vector3 camOffset = new Vector3(0,4.32f,-6.98f);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			transform.Translate (new Vector3 (speed, 0, 0));
		}
		if (Input.GetKey ("left")) {
			transform.Translate (new Vector3 (-speed, 0, 0));
		}
		if (Input.GetKey ("up")) {
			transform.Translate (new Vector3 (0, 0, speed));
		}
		if (Input.GetKey ("down")) {
			transform.Translate (new Vector3 (0, 0, -speed));
		}

		cam.SetPositionAndRotation (transform.position + camOffset, cam.rotation);
	}
}
