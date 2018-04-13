using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	private Vector3[] positions;

	void Start () {
		positions = new Vector3[4];
		positions[0] = new Vector3(-.25f, 0f, 0f);
		positions[1] = new Vector3(0, .25f, 0f);
		positions[2] = new Vector3(.25f, 0f, 0f);
		positions[3] = new Vector3(0, -.25f, 0f);
	}

	// Update is called once per frame
	void Update ()
	{
		CheckIfOutside();
		transform.Translate(Vector3.forward * -1f *  Time.deltaTime * 10f);
		//	transform.localPosition = new Vector3(0f, 1f, transform.localPosition.z);
	}

	void CheckIfOutside()
	{
		if (transform.position.z < -15f)
		{
			transform.position = positions[Random.Range(0, 4)] + new Vector3(0f, 0f, Random.Range(8f, 12f));
		}
	}
}
