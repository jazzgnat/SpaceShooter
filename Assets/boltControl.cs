using UnityEngine;
using System.Collections;

public class boltControl : MonoBehaviour {

	private Vector3 v3_Forward;
	public float speed = 20.0f;
	private Rigidbody bolt;

	// Use this for initialization
	void Start () {
		rigidbody.AddForce (transform.up * speed);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void fixedUpdate () {

		
	}

}
