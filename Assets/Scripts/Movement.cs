using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


	public float Speed;

	private void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.W))
		{
			GetComponent<Rigidbody>().velocity = transform.forward * Speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			GetComponent<Rigidbody>().velocity = -transform.forward * Speed;
		}

		if (Input.GetKey(KeyCode.A))
		{

		}
	}

}
