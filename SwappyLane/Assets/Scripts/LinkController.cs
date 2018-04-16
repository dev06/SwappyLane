using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour {

	public static LinkController Instance; 

	public static float MIN_VELOCITY = 5f; 

	public static float MAX_VELOCITY = 20; 

	private float velocity = MIN_VELOCITY; 

	private int index; 

	private float timer; 

	private float startingDelay; 

	private int movingLinkIndex = 0; 



	private LevelController levelController; 

	private CameraController cameraController; 

	private Controller controller; 

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
	}

	void OnDisable()
	{
		EventManager.OnObstacleHit-=OnObstacleHit; 
		LevelController.OnLevelComplete-=OnLevelComplete; 
	}


	void OnObstacleHit()
	{
		Velocity = MIN_VELOCITY; 
	}

	void OnLevelComplete()
	{
		movingLinkIndex = 0; 
	}

	void Start () {
		controller = Controller.Instance; 
		cameraController = CameraController.Instance; 
		levelController = LevelController.Instance; 
		levelController.Initalize(); 
	}
	
	void Update () {

		velocity+=Time.deltaTime;  // temp. replace with diff; 

		velocity = Mathf.Clamp(velocity, MIN_VELOCITY, levelController.level.MaxLevelVelocity); 

//		Debug.Log(velocity + " " +levelController.level.MaxLevelVelocity); 

		startingDelay = (10f) / Velocity; 

		cameraController.UpdateZoomStatus(levelController.level.MaxLevelVelocity == velocity); 
		
		startingDelay = Mathf.Clamp(startingDelay, .4f, 1f); 

//		Debug.Log(levelController.level.Index + " " + levelController.level.MaxLevelVelocity);

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
		if(index < controller.links.Count - 1)
		{
			index++; 
		}
		else
		{
			index = 0; 
		}


		Link l = controller.links[index].GetComponent<Link>(); 
		l.transform.gameObject.SetActive(true); 
		l.CanTranslate = true; 
		movingLinkIndex++; 
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
