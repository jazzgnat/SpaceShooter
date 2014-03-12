using UnityEngine;
using System.Collections;

public class boltControl : MonoBehaviour {
	
	public float speed = 20.0f;

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
