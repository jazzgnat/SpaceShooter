using UnityEngine;
using System.Collections;

public class astroControl : MonoBehaviour {


	public bool collide = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter(Collision myCol)
	{
		if(myCol.gameObject.name == "Cube")
			collide = true;
	}
}
