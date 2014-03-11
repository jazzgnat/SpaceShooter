using UnityEngine;
using System.Collections;

public class shipControl : MonoBehaviour {
	
	public float rotationAcceleration = 1.0f;
	public Vector3 Direction = new Vector3(0,0,0);
	public float speed = 200.0f;
	static Vector3 moveForce;
	static Rigidbody ship;


	public bool isMoving = false;

	// Use this for initialization
	void Start () {
		ship = transform.rigidbody;
		moveForce = Vector3.zero;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.T))
				if (!isMoving) {
						//moveForce = transform.forward; 
						rigidbody.velocity = transform.forward;
						isMoving = true;
				} else {
						//moveForce = Vector3.zero;
						ship.velocity = Vector3.zero;
						isMoving = false;
				}

		if (Input.GetKeyDown (KeyCode.G))
						rigidbody.angularVelocity = Vector3.zero;

		float Vrotation = Input.GetAxis("Vertical");
		float Hrotation = Input.GetAxis("Horizontal");
		float Yrotation = Input.GetAxis ("Yaw");

		Direction = new Vector3(Vrotation, Yrotation, Hrotation);

				}
	

	void FixedUpdate(){

		Vector3 deltaRotationVelocity = Direction * Time.deltaTime * rotationAcceleration;
		rigidbody.angularVelocity += deltaRotationVelocity;
		//Vector3 moveForceVelocity = moveForce * speed * Time.deltaTime;
		//rigidbody.velocity += moveForceVelocity;

	}
}
