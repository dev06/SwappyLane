using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool auto;
	private float timer = 0;

	public ParticleSystem trail;

	public ParticleSystem characterFragments;
	void OnEnable()
	{
		EventManager.OnTerminalVelocityStatus += OnTerminalVelocityStatus;
		LevelController.OnLevelComplete += OnLevelComplete;
		EventManager.OnGameOver += OnGameOver;

	}
	void OnDisable()
	{
		EventManager.OnTerminalVelocityStatus -= OnTerminalVelocityStatus;
		LevelController.OnLevelComplete -= OnLevelComplete;
		EventManager.OnGameOver -= OnGameOver;

	}

	void OnTerminalVelocityStatus(bool b)
	{
		if (b)
		{
			trail.Play();
		}
		else
		{
			trail.Stop();
		}
	}

	void OnLevelComplete()
	{
		trail.Stop();
	}

	void OnGameOver()
	{
		transform.GetComponent<MeshRenderer>().enabled = false;
		characterFragments.Play();
		characterFragments.transform.position = transform.position;
		StopCoroutine("IOnGameOver");
		StartCoroutine("IOnGameOver");
	}

	IEnumerator IOnGameOver()
	{
		float timer = 0;
		while (timer < 1.0f)
		{
			timer += Time.deltaTime;
			yield return null;
		}
		UnityEngine.SceneManagement.SceneManager.LoadScene(0);

	}


	void Start () {
	}

	// Update is called once per frame
	void Update ()
	{
		if (Controller.GameState != State.GAME) return;
		if (auto)
		{
			AutoRotate();
		}

		transform.Rotate(new Vector3(0, 0, 1720f * Time.deltaTime));
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
