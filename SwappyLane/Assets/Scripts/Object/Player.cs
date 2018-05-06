using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool auto;
	private float timer = 0;

	public ParticleSystem trail;

	public ParticleSystem characterFragments;

	private float terminalVelocity = 1000f;
	private float defaultVelocity = 700f;
	private float rotatingVelocity;
	private LinkController linkController; 
	private Link hitLink; 
	void OnEnable()
	{
		EventManager.OnTerminalVelocityStatus += OnTerminalVelocityStatus;
		LevelController.OnLevelComplete += OnLevelComplete;
		EventManager.OnGameOver += OnGameOver;
		EventManager.OnSecondChance +=OnSecondChance;
		EventManager.OnSecondChanceDecision+=OnSecondChanceDecision; 

	}
	void OnDisable()
	{
		EventManager.OnTerminalVelocityStatus -= OnTerminalVelocityStatus;
		LevelController.OnLevelComplete -= OnLevelComplete;
		EventManager.OnGameOver -= OnGameOver;
		EventManager.OnSecondChance -=OnSecondChance;
		EventManager.OnSecondChanceDecision-=OnSecondChanceDecision; 

	}

	void OnTerminalVelocityStatus(bool b)
	{
		if (b)
		{
			trail.Play();
			rotatingVelocity = terminalVelocity;
		}
		else
		{
			trail.Stop();
			rotatingVelocity = defaultVelocity;

		}
	}

	void OnLevelComplete()
	{
		trail.Stop();
	}

	void OnGameOver()
	{
		if (!Controller.isGameOver)
		{
			Controller.isGameOver = true;
			Controller.Freeze = true; 
			transform.GetComponent<MeshRenderer>().enabled = false;
			characterFragments.Play();
			characterFragments.transform.position = transform.position;
			if (Controller.GameState == State.PAUSE)
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(0);
			}
			StopCoroutine("IOnGameOver");
			StartCoroutine("IOnGameOver", false);
		}
	}

	bool secondChanceLock; 
	void OnSecondChance()
	{
		if(!secondChanceLock)
		{
			secondChanceLock = true; 
			Controller.Freeze = true; 
			transform.GetComponent<MeshRenderer>().enabled = false;
			characterFragments.Play();
			characterFragments.transform.position = transform.position;
			StopCoroutine("IOnGameOver");
			StartCoroutine("IOnGameOver", true);		
		}
	}

	void OnSecondChanceDecision(bool b)
	{
		if(!b)
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}
		else
		{
			secondChanceLock = false; 
			Controller.SetState(State.GAME); 
			Controller.Freeze = false; 
			transform.GetComponent<MeshRenderer>().enabled = true;
			linkController.DeactivateAllLinks(); 
			
		}
	}

	IEnumerator IOnGameOver(bool isSecondChance)
	{
		yield return new WaitForSeconds(1f); 
		if(isSecondChance)
		{
			Controller.SetState(State.SECOND_CHANCE); 

		}
		else
		{
			UnityEngine.SceneManagement.SceneManager.LoadScene(0);
		}
	}


	void Start ()
	{
		rotatingVelocity = defaultVelocity;

		linkController = LinkController.Instance; 

		secondChanceLock = false; 
	}


	// Update is called once per frame
	void Update ()
	{
		//Debug.Log("fsfsf");
		if (Controller.GameState != State.GAME) return;
		if (auto)
		{
			AutoRotate();
		}

		transform.Rotate(new Vector3(0, 0, rotatingVelocity * Time.deltaTime));
		StatRecordController.MetersRolled += Time.deltaTime / 10f;
	}

	private void AutoRotate()
	{
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		timer += Time.deltaTime;
		RaycastHit hit;
		if (Physics.Raycast(transform.position, fwd, out hit))
		{
			if (hit.collider.gameObject != null)
			{

				if (hit.distance < 7f)
				{
					if (timer > .1f)
					{
						FindObjectOfType<Platform>().Rotate();
						timer = 0;
					}
				}
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Objects/Obstacle")
		{
			if (EventManager.OnObstacleHit != null)
			{
				EventManager.OnObstacleHit(col.gameObject);
			}
			hitLink = col.gameObject.GetComponent<Obstacle>().Link; 
		}
		else if (col.gameObject.tag == "Objects/Coin")
		{
			if (EventManager.OnCoinHit != null)
			{
				EventManager.OnCoinHit(col.gameObject);
			}
		}
	}
}
