using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject Cradle;
	public GameObject Chase;
	public GameObject Camera;

	public CharacterController cc;

	//Use this for initialization
	void Start ()
	{

	}

	//Update is called once per frame
	void Update ()
	{
		Cradle.transform.position = this.transform.position;
		Camera.transform.position = Vector3.Lerp(Camera.transform.position, Chase.transform.position, 2 * Time.deltaTime);
		Camera.transform.LookAt(this.transform);

		if (Input.GetMouseButton(0)) {
			Vector2 mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
			Vector3 cradleRotation = Cradle.transform.eulerAngles;
			cradleRotation.y -= mouseInput.x;
			cradleRotation.x += mouseInput.y;
			Cradle.transform.eulerAngles = cradleRotation;
		}

		Vector3 moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

		cc.Move(moveInput);
	}
}
