using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

	private Controller controller;

	private List<int> positionDirection;

	private List<int> availablePositionDirection;

	public List<GameObject> obstacles;

	private List<Vector3> availablePosition;

	private Vector3 chosenLocation;

	private Link prevLink;

	private bool canTranslate;

	private float timer = 0;

	private Quaternion targetRotation;

	private LinkController linkController;

	private LevelController levelController;

	private GameObject coin;

	private Player player;

	void OnEnable()
	{
		EventManager.OnStateChange += OnStateChange;
	}

	void OnDisable()
	{
		EventManager.OnStateChange -= OnStateChange;
	}

	void OnStateChange(State s)
	{
		if (s == State.GAME)
		{
			Initalize();
		}
	}

	void Initalize ()
	{

		controller = Controller.Instance;
		linkController = LinkController.Instance;
		levelController = LevelController.Instance;
		obstacles = new List<GameObject>();

		positionDirection = new List<int>();
		positionDirection.Add(0);
		positionDirection.Add(1);
		positionDirection.Add(2);
		positionDirection.Add(3);

		availablePositionDirection = positionDirection;


		chosenLocation = transform.localPosition;

		GameObject prefab = CharacterSelector.ActiveThemePackage.model.transform.GetChild(1).gameObject;

		GameObject coin_prefab = AppResources.Coin;

		player = FindObjectOfType<Player>();

		float scaleMultiplier = .9f;

		for (int i = 0; i < 4; i++)
		{
			GameObject clone = (GameObject)Instantiate(prefab) as GameObject;
			clone.transform.SetParent(transform);

			clone.transform.localScale = new Vector3(1, 1, clone.transform.localScale.z) * scaleMultiplier;
			obstacles.Add(clone);
			clone.SetActive(false);
		}

		GameObject coin = (GameObject)Instantiate(coin_prefab) as GameObject;
		coin.transform.SetParent(transform);
		coin.transform.localScale = new Vector3(1, 1, coin.transform.localScale.z);
		coin.transform.localScale *= .25f;
		coin.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, 45));
		coin.SetActive(false);
		this.coin = coin;

		ActiveCubes();

		ChangeCubeSides();

		transform.gameObject.SetActive(false);

		targetRotation = transform.localRotation;
	}

	private void ActiveCubes()
	{
		for (int i = 0; i < obstacles.Count; i++)
		{
			obstacles[i].SetActive(false);
		}

		int count =	Random.Range(1, (levelController.level.Index / 2) + 1);

		count = Mathf.Clamp(count, 1, 3);

		for (int i = 0; i < count; i++)
		{
			obstacles[i].SetActive(true);
		}

	}


	void Update ()
	{
		if (Controller.isGameOver) { return; }
		if (Controller.GameState != State.GAME) { return; }
		CheckIfOutside();
		UpdateObstacleRotation();


		if (CanTranslate)
		{
			transform.Translate(Vector3.forward * -1f *  Time.deltaTime * linkController.Velocity);
		}

		transform.localPosition = new Vector3(chosenLocation.x, chosenLocation.y, transform.localPosition.z);
	}

	void UpdateObstacleRotation()
	{
		if (levelController.level.Index < 8) { return; }

		if (Vector3.Distance(transform.position, player.transform.position) > 10)
		{
			timer += Time.deltaTime;
			if (timer > 1.0f)
			{
				int prob = Random.Range(0, 2) == 0 ? -1 : 1;
				targetRotation *= Quaternion.Euler(new Vector3(0, 0, prob * 90));
				timer = 0;
			}

		}

		transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime * 20f);

	}

	void CheckIfOutside()
	{

		if (transform.localPosition.z < -.5f)
		{
			transform.localPosition = new Vector3(0, 0, .5f);
			CanTranslate = false;
			ChangeCubeSides();
			levelController.UpdateLevelProgress();
			transform.gameObject.SetActive(false);
		}
	}

	private Vector3 GetPositionByDirection(int direction)
	{
		switch (direction)
		{
			case 0: return new Vector3(0, 1, 0f);
			case 1: return new Vector3(1, 0, 0f);
			case 2: return new Vector3(0, -1, 0f);
			case 3: return new Vector3(-1, 0, 0f);
			default: return Vector3.zero;
		}
	}


	private void ChangeCubeSides()
	{

		positionDirection.Clear();

		positionDirection.Add(0);
		positionDirection.Add(1);
		positionDirection.Add(2);
		positionDirection.Add(3);

		availablePositionDirection = positionDirection;

		ActiveCubes();
		int rand = Random.Range(0, obstacles.Count);

		for (int i = 0; i < obstacles.Count; i++)
		{
			int dir = 0;

			if (rand == i)
			{
				if (Random.Range(0f, 1f) < .2f)
				{
					dir = FindObjectOfType<Platform>().direction;
				}
				else
				{
					dir = availablePositionDirection[Random.Range(0, availablePositionDirection.Count)];
				}
			}
			else
			{
				dir = availablePositionDirection[Random.Range(0, availablePositionDirection.Count)];
			}

			obstacles[i].transform.localPosition  = GetPositionByDirection(dir);
			obstacles[i].transform.localRotation = Quaternion.Euler(Vector3.zero);

			if (obstacles[i].activeSelf)
			{
				availablePositionDirection.Remove(dir);
			}

		}


		Vector3 remainingLoc = GetPositionByDirection(availablePositionDirection[Random.Range(0, availablePositionDirection.Count)]);
		coin.SetActive(true);
		coin.transform.localPosition = remainingLoc;



	}

	public Link PrevLink
	{
		get {
			return prevLink;
		}

		set {
			prevLink = value;
		}
	}

	public bool CanTranslate
	{
		get {
			return canTranslate;
		}
		set {
			this.canTranslate = value;
		}
	}
}
