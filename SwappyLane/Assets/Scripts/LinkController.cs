﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour {

	public static LinkController Instance; 

	public static float MIN_VELOCITY = 5f; 

	public static float MAX_VELOCITY = 10f; 

	private float velocity = MIN_VELOCITY; 

	private int index; 

	private float timer; 

	private float startingDelay; 

	private int movingLinkIndex = 0; 

	private bool atTerminalVelocity; 

	private LevelController levelController; 

	private CameraController cameraController; 

	private Controller controller; 

	private ParticleSystem fragments; 

	private ParticleSystem tmVelocity; 

	private bool terminalVelocityStart; 

	void Awake()
	{
		if(Instance == null)
		{
			Instance = this; 
		}
	}

	void OnEnable()
	{
		EventManager.OnObstacleHit+=OnObstacleHit; 

		LevelController.OnLevelComplete+=OnLevelComplete; 

		LevelController.OnNewLevelStart+=OnNewLevelStart; 
	}

	void OnDisable()
	{
		EventManager.OnObstacleHit-=OnObstacleHit; 
		
		LevelController.OnLevelComplete-=OnLevelComplete; 
		
		LevelController.OnNewLevelStart-=OnNewLevelStart; 

	}


	void OnObstacleHit(GameObject o)
	{
		if(atTerminalVelocity)
		{			
			
			fragments.transform.position = o.transform.position; 
			
			fragments.Play(); 
			
			Velocity = MIN_VELOCITY; 
			
			o.SetActive(false); 
			
			tmVelocity.Stop(); 
			
			terminalVelocityStart = false; 

			if(EventManager.OnTerminalVelocityStatus != null)
			{
				EventManager.OnTerminalVelocityStatus(false); 
			}
		}

		else
		{
			Controller.isGameOver = true; 
			//GAME OVER
			if(EventManager.OnGameOver != null)
			{
				EventManager.OnGameOver(); 
			}
		}
	}

	void OnLevelComplete()
	{
		Velocity = MIN_VELOCITY; 
		
		tmVelocity.Stop(); 
		
		terminalVelocityStart = false; 
		
		index = 0; 

	}

	void OnNewLevelStart()
	{
		movingLinkIndex = 0; 
	}

	void Start ()
	{
		controller = Controller.Instance; 
		
		cameraController = CameraController.Instance; 
		
		levelController = LevelController.Instance; 
		
		levelController.Initalize(); 

		fragments = GameObject.Find("ObstacleFragments").GetComponent<ParticleSystem>(); 

		tmVelocity = GameObject.Find("TerminalVelocityBoost").GetComponent<ParticleSystem>(); 
	}
	
	void Update () {

		if(Controller.isGameOver) return; 
		
		atTerminalVelocity = levelController.level.MaxLevelVelocity == velocity; 

		if(atTerminalVelocity)
		{
			if(!terminalVelocityStart)
			{
				if(EventManager.OnTerminalVelocityStatus != null)
				{
					EventManager.OnTerminalVelocityStatus(true); 
				}
				tmVelocity.Play(); 
				
				terminalVelocityStart = true; 
			}
		}


		velocity+=Time.deltaTime;  // temp. replace with diff; 

		velocity = Mathf.Clamp(velocity, MIN_VELOCITY, levelController.level.MaxLevelVelocity); 

		float delay = -Mathf.Log(levelController.level.Index, 10) * 4f + 10f; 

		delay = Mathf.Clamp(delay, 4.75f, delay); 

		startingDelay = delay / Velocity; 

		cameraController.UpdateZoomStatus(atTerminalVelocity); 
		
		startingDelay = Mathf.Clamp(startingDelay, .45f, 1f); 

		if(levelController.level != null)
		{
			if(movingLinkIndex < levelController.level.Length)
			{
				timer+=Time.deltaTime; 

				if(timer > startingDelay)
				{
					MoveNextLink();
					timer = 0; 
				}		
			}
			
		}
	}

	private void MoveNextLink()
	{
		Link l = controller.links[index].GetComponent<Link>(); 
		
		l.transform.gameObject.SetActive(true); 
		
		l.CanTranslate = true; 
		
		movingLinkIndex++; 

		if(index < controller.links.Count - 1)
		{
			index++; 
		}
		else
		{
			index = 0; 
		}
	}

	public float Velocity{
		get {
			return velocity; 
		}

		set{
			this.velocity = value; 
		}
	}
}