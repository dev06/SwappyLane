using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public static CameraController Instance; 

	void Awake()
	{
		if(Instance == null)
		{
			Instance = this; 
		}
	}
	Camera camera;
	float targetFOV; 
	float targetSpeed; 
	float fovVel; 

	void Start () 
	{
		camera = GetComponent<Camera>(); 
		targetFOV = camera.fieldOfView; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Controller.GameState != State.GAME) return; 
		camera.fieldOfView = Mathf.SmoothDamp(camera.fieldOfView, targetFOV, ref fovVel, Time.deltaTime * targetSpeed); 
	}

	public void UpdateZoomStatus(bool b)
	{	
		if(b)
		{
			targetFOV = 70f; 
			targetSpeed = 60f; 
		}
		else
		{
			targetFOV = 55f; 
			targetSpeed = 10f; 
		}
	}
}
