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
	void LateUpdate() {
		Vector3 desiredPosition = target.transform.position + offset;
		transform.position = desiredPosition;
	}
}
