using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(PlayerMotor))]
public class PlayerInput : MonoBehaviour {
	float hori; //Horizontal Axis
	float vert; //Vertical Axis
	[SerializeField]float ispeed; //Speed given from editor

	private PlayerMotor motor;

	void Start(){
		motor = GetComponent<PlayerMotor> ();
	}

	// Update is called once per frame
	void Update () {
		//Assigns the Axis to the previously created variables
		hori = Input.GetAxisRaw ("Horizontal");
		vert = Input.GetAxisRaw ("Vertical");
		//Creates velocity vectors
		Vector3 _movHori = transform.right * hori;
		Vector3 _movVert = transform.forward * vert;

		Vector3 _velocity = (_movHori + _movVert).normalized * ispeed;

		motor.Move(_velocity);
  }


}
