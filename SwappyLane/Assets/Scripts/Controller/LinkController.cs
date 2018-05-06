using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkController : MonoBehaviour {

	public static LinkController Instance;

	public static float SEC_VELOCITY = 1F; 

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

	private CoinController coinController; 

	private Controller controller;

	private ParticleSystem fragments;

	private ParticleSystem tmVelocity;

	private bool terminalVelocityStart;

	private bool canCollideAgain = true;

	private Link[] linkList; 



	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}
	}

	public void Initalize()
	{
		controller = Controller.Instance;

		cameraController = CameraController.Instance;

		levelController = LevelController.Instance;

		coinController = CoinController.Instance; 

		levelController.Initalize();

		tmVelocity = GameObject.Find("TerminalVelocityBoost").GetComponent<ParticleSystem>();

		linkList = FindObjectsOfType<Link>();  
	}


	void OnEnable()
	{
		EventManager.OnObstacleHit += OnObstacleHit;

		LevelController.OnLevelComplete += OnLevelComplete;

		LevelController.OnNewLevelStart += OnNewLevelStart;

		EventManager.OnSecondChanceDecision +=OnSecondChanceDecision; 
	}

	void OnDisable()
	{
		EventManager.OnObstacleHit -= OnObstacleHit;

		LevelController.OnLevelComplete -= OnLevelComplete;

		LevelController.OnNewLevelStart -= OnNewLevelStart;

		EventManager.OnSecondChanceDecision -=OnSecondChanceDecision; 

	}

	void OnSecondChanceDecision(bool b)
	{
		if(b)
		{

			tmVelocity.Stop();

			terminalVelocityStart = false;

			if (EventManager.OnTerminalVelocityStatus != null)
			{
				EventManager.OnTerminalVelocityStatus(false);
			}

			Velocity = SEC_VELOCITY; 
		}

		else
		{

			if (EventManager.OnGameOver != null)
			{
				EventManager.OnGameOver();
			}

		}
	}

	public void DeactivateAllLinks()
	{
		foreach(Link l in linkList)
		{
			l.Deactivate(); 
		}

		movingLinkIndex = (int)levelController.level.Progress; 

		index = 0; 
	}



	IEnumerator HitCoolDown()
	{
		canCollideAgain = false;

		float timer = 0;

		while (timer < .2f)
		{
			timer += Time.deltaTime;
			yield return null;
		}

		canCollideAgain = true;
		StopCoroutine("HitCoolDown");
	}


	void OnObstacleHit(GameObject o)
	{
		if (atTerminalVelocity)
		{
			Velocity = MIN_VELOCITY;

			o.SetActive(false);

			tmVelocity.Stop();

			terminalVelocityStart = false;

			if (EventManager.OnTerminalVelocityStatus != null)
			{
				EventManager.OnTerminalVelocityStatus(false);
			}

			StatRecordController.BlocksBreaked++;

			StopCoroutine("HitCoolDown");
			StartCoroutine("HitCoolDown");

			Haptic.Vibrate(HapticIntensity.Heavy);
		}

		else
		{

			if (canCollideAgain)
			{	

				if (EventManager.OnTerminalVelocityStatus != null)
				{
					EventManager.OnTerminalVelocityStatus(false);
				}

				Controller.CONTINUE_COST = levelController.level.Index * 5; 

				if(StatRecordController.CoinsCollected >= Controller.CONTINUE_COST)
				{
					if(EventManager.OnSecondChance != null)
					{
						EventManager.OnSecondChance(); 
					}
				}
				else
				{
					if (EventManager.OnGameOver != null)
					{
						EventManager.OnGameOver();
					}
				}

				Haptic.Vibrate(HapticIntensity.Heavy);
			}
		}
	}

	void OnLevelComplete()
	{
		Velocity = MIN_VELOCITY;

		tmVelocity.Stop();

		terminalVelocityStart = false;

		index = 0;

		if(linkList == null)
		{
			linkList =FindObjectsOfType<Link>(); 
		}

		foreach(Link l in linkList)
		{
			l.transform.gameObject.SetActive(false); 
		}
	}

	void OnNewLevelStart()
	{
		movingLinkIndex = 0;
	}


	void Update () {

		if (Controller.Freeze) { return; }
		if (Controller.GameState != State.GAME) { return; }


		atTerminalVelocity = levelController.level.MaxLevelVelocity == velocity;

		if (atTerminalVelocity)
		{
			if (!terminalVelocityStart)
			{
				if (EventManager.OnTerminalVelocityStatus != null)
				{
					EventManager.OnTerminalVelocityStatus(true);
				}
				tmVelocity.Play();

				terminalVelocityStart = true;
			}
		}


		velocity += Time.deltaTime; // temp. replace with diff;

		velocity = Mathf.Clamp(velocity, MIN_VELOCITY, levelController.level.MaxLevelVelocity);

		float delay = -Mathf.Log(levelController.level.Index, 10) * 3f + 10f;

		delay = Mathf.Clamp(delay, 4.75f, delay);

		//		Debug.Log(delay);

		startingDelay = delay / Velocity;

		cameraController.UpdateZoomStatus(atTerminalVelocity);

		startingDelay = Mathf.Clamp(startingDelay, .47f, 1f);

		if (levelController.level != null)
		{
			if (movingLinkIndex < levelController.level.Length)
			{
				timer += Time.deltaTime;

				if (timer > startingDelay)
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

		l.UpdateLinkCubes(); 

		movingLinkIndex++;

		if (index < controller.links.Count - 1)
		{
			index++;
		}
		else
		{
			index = 0;
		}
	}

	public float Velocity {
		get {
			return velocity;
		}

		set {
			this.velocity = value;
		}
	}

	public bool AtTerminalVelocity
	{
		get {
			return atTerminalVelocity;
		}
	}
}
