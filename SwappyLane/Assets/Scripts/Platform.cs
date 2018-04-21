using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {


	private Quaternion targetRotation;

	public int direction = 0; 

	void Start ()
	{
		targetRotation = transform.rotation;
	}


	void Update () {
		if(Controller.isGameOver) return; 
		RotatePlatform();
	}

	void RotatePlatform()
	{
//		Debug.Log(direction); 
		if (Input.GetMouseButtonDown(0))
		{
			Vector2 position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
			float xp = Mathf.Clamp(position.x, 0f, 1f);
			float dir = xp < .5f ? -1f : 1f;
			direction+=(int)dir; 
			if(direction < 0)
			{
				direction = 3; 
			}
			else if(direction > 3)
			{
				direction = 0; 
			}
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, 90 * dir));
		}
		transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * 10f);

		if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
		{
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, -90));
			direction--; 
			if(direction < 0)
			{
				direction = 3; 
			}
		}
		else if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
		{
			targetRotation *= Quaternion.Euler(new Vector3(0, 0, 90));
			direction++; 
			if(direction > 3)
			{
				direction =0; 
			}
		}

	}

	public void Rotate()
	{
		targetRotation *= Quaternion.Euler(new Vector3(0, 0, -90));
	}
}
