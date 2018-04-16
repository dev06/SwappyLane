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
	float fovVel; 

	void Start () 
	{
		camera = GetComponent<Camera>(); 
		targetFOV = camera.fieldOfView; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		camera.fieldOfView = Mathf.SmoothDamp(camera.fieldOfView, targetFOV, ref fovVel, Time.deltaTime * 10f); 
	}

	public void UpdateZoomStatus(bool b)
	{	
		targetFOV = b ? 70f : 55f; 
	}
}
