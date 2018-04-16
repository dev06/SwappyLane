using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {


	private Quaternion targetRotation;
	void Start ()
	{
		targetRotation = transform.rotation;
	}


	void Update () {

		RotatePlatform();
	}

	void RotatePlatform()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			float xp = Mathf.Clamp(position.x, 0f, 1f);
			float direction = xp < .5f ? -1f : 1f;
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, 90 * direction));
		}

		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, -90));
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow))
		{
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, 90));
		}

		transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
	}
}
