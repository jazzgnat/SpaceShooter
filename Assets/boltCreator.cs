using UnityEngine;
using System.Collections;

public class boltCreator : MonoBehaviour {
	private GameObject bolt;
	// Use this for initialization
	void Start () {
	
		bolt = GameObject.Find ("bolt");
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("fire1"))
						Instantiate (bolt);
	
	}
}
