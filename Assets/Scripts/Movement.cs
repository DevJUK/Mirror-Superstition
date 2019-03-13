using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


	public float Speed;
	public float RotationSpeed;

	private void FixedUpdate()
	{

		if (gameObject.tag == "P1")
		{
			if (Input.GetAxis("P1Move") > 0)
			{
				GetComponent<Rigidbody>().velocity = transform.forward * Speed;
			}
			else if (Input.GetAxis("P1Move") < 0)
			{
				GetComponent<Rigidbody>().velocity = -transform.forward * Speed;
			}

			transform.Rotate(new Vector3(0, Input.GetAxis("P1Rot"), 0) * Time.deltaTime * 150f);
		}


		if (gameObject.tag == "P2")
		{
			if (Input.GetAxis("P2Move") > 0)
			{
				GetComponent<Rigidbody>().velocity = transform.forward * Speed;
			}
			else if (Input.GetAxis("P2Move") < 0)
			{
				GetComponent<Rigidbody>().velocity = -transform.forward * Speed;
			}

			transform.Rotate(new Vector3(0, Input.GetAxis("P2Rot"), 0) * Time.deltaTime * 150f);
		}


		if (gameObject.tag == "P3")
		{
			if (Input.GetAxis("P3Move") > 0)
			{
				GetComponent<Rigidbody>().velocity = transform.forward * Speed;
			}
			else if (Input.GetAxis("P3Move") < 0)
			{
				GetComponent<Rigidbody>().velocity = -transform.forward * Speed;
			}

			transform.Rotate(new Vector3(0, Input.GetAxis("P3Rot"), 0) * Time.deltaTime * 150f);
		}



	}

}
