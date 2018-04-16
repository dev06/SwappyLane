using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	private Vector3[] positions;
	private Vector3 chosenLocation; 

	void Start () {
		positions = new Vector3[4];
		positions[0] = new Vector3(-1f, 0f, 0f);
		positions[1] = new Vector3(0, 1f, 0f);
		positions[2] = new Vector3(1f, 0f, 0f);
		positions[3] = new Vector3(0, -1f, 0f);
		//transform.localPosition = new Vector3(0, 1, transform.localPosition.z); 
	}

	// Update is called once per frame
	void Update ()
	{
		//CheckIfOutside();
		//transform.Translate(Vector3.forward * -1f *  Time.deltaTime * 10f);
		//transform.localPosition = new Vector3(chosenLocation.x, chosenLocation.y, transform.localPosition.z); 

	}

	void CheckIfOutside()
	{
		if (transform.localPosition.z < -.5f)
		{
			chosenLocation = positions[Random.Range(0, 4)] + new Vector3(0f, 0f, .5f);
			transform.localPosition = chosenLocation; 

		}
	}
}
