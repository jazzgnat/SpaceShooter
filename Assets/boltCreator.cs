using UnityEngine;
using System.Collections;

public class boltCreator : MonoBehaviour {

	public GameObject bolt;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1")) {

						Instantiate (bolt, transform.position, transform.rotation);
				}
	
	}
}
