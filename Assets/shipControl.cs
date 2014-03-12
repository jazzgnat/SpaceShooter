using UnityEngine;
using System.Collections;

public class shipControl : MonoBehaviour {
	
	public float rotationAcceleration = 1.0f;
	public Vector3 Direction = new Vector3(0,0,0);
	public float lowSpeed = 2.0f;
	public float highSpeed = 100.0f;
	public float speed = 2.0f;
	static Vector3 moveForce;
	static Rigidbody ship;
	public bool isHighSpeed = false;
	public bool isMoving = false;

	// Use this for initialization
	void Start () {
		ship = transform.rigidbody;
		moveForce = Vector3.zero;
		speed = lowSpeed;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.B)) {
				if (speed == lowSpeed){
				speed = highSpeed;
				isHighSpeed = true;
				}else{
				speed = lowSpeed;
				isHighSpeed = false;}
		}

		if (Input.GetKeyDown (KeyCode.T)) {
					if (!isMoving) {
						moveForce = transform.forward * speed;
						moveForce = Vector3.Normalize (moveForce); 
						rigidbody.velocity = moveForce;
						isMoving = true;
					} else {
						//moveForce = Vector3.zero;
						ship.velocity = Vector3.zero;
						isMoving = false;
					}
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
		//Vector3 moveForceVelocity = moveForce * speed;
		//rigidbody.velocity = moveForceVelocity;

	}
}
