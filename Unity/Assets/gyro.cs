﻿using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;


	}
	
	// Update is called once per frame
	void Update () {

		transform.rotation = Quaternion.AngleAxis(90.0f,Vector3.right)*Input.gyro.attitude*Quaternion.AngleAxis(180.0f,Vector3.forward);

		//transform.rotation = Quaternion.AngleAxis(90.0f,Vector3.right)*Input.gyro.attitude*Quaternion.AngleAxis(180.0f,Vector3.forward);

	}
}
