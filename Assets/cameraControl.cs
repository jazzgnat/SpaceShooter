using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

	public GameObject target = null;
	private Vector3 offset = Vector3.zero;

	// Use this for initialization
	void Start () {
	
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (target != null) {
			transform.LookAt (target.transform);	
		}
	}
}
