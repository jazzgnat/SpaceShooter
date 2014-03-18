using UnityEngine;
using System.Collections;

public class AstroCreator : MonoBehaviour {

	public GameObject asteroid;
	private int count = 0; 

	// Use this for initialization
	void Start () {

		while(count < 20){
		Instantiate (asteroid, transform.position, transform.rotation);
			count ++;
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
