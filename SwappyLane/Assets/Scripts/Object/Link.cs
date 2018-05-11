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

	private bool gameInit;

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
			if (gameInit == false)
			{
				Initalize();

				gameInit = true;
			}
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

			clone.transform.localScale = new Vector3(1, 1, 1f / 100f) * scaleMultiplier;
			clone.GetComponent<Obstacle>().Link = this; 
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

		//0 - 1 -> 1
		//0 - 2 -> 2
		//0 - 3 -> 3

		float spawn_val = levelController.level.Index; 
		float progress = (levelController.level.Progress / levelController.level.Length); 

		int count = 0; 

		float c3_start = -.1f * Mathf.Log(levelController.level.Index, 10) + 0.3f; 
		float c2_start = -.1f * Mathf.Log(levelController.level.Index, 10) + 0.2f; 




		if(progress > c3_start)
		{
			count = levelController.level.Index >= 6 ? 3 : levelController.level.Index >= 3  ? 2 : 1; 
		}
		else if(progress > c2_start)
		{
			count = levelController.level.Index >= 3 ? 2 : 1;
		}
		else
		{
			count = 1; 
		}



		count = Random.Range(1, count + 1); 


		count = Mathf.Clamp(count, 1, 3);

		for (int i = 0; i < count; i++)
		{
			obstacles[i].SetActive(true);
		}

	}


	void Update ()
	{
		if (Controller.Freeze) { return; }
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
		if (levelController.level.Index < 7) { return; }

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

	public void Deactivate()
	{
		transform.localPosition = new Vector3(0, 0, .5f);
		CanTranslate = false;
		//levelController.UpdateLevelProgress();
		transform.gameObject.SetActive(false);
		//CheckForCoinMiss(); 
	}


	void CheckIfOutside()
	{

		if (transform.localPosition.z < -.5f)
		{
			transform.localPosition = new Vector3(0, 0, .5f);
			CanTranslate = false;
			levelController.UpdateLevelProgress();
			transform.gameObject.SetActive(false);
			CheckForCoinMiss(); 
			//Debug.Log(this.coin.activeSelf); 
		}
	}

	private void CheckForCoinMiss()
	{
		if(this.coin.activeSelf)
		{
			if(EventManager.OnCoinMiss != null)
			{
				EventManager.OnCoinMiss(); 
			}				
		}
	}

	private Vector3[] GetPositionByDirection(int direction)
	{
		switch (direction)
		{
			case 0: return new Vector3[2] { new Vector3(0, 1, 0f), new Vector3(0, 0, 0)};
			case 1: return new Vector3[2] { new Vector3(1, 0, 0f), new Vector3(0, 0, -90)};
			case 2: return new Vector3[2] { new Vector3(0, -1, 0f), new Vector3(0, 0, 180)};
			case 3: return new Vector3[2] { new Vector3(-1, 0, 0f), new Vector3(0, 0, 90)};
		}

		return null;
	}

	public void UpdateLinkCubes()
	{
		ChangeCubeSides(); 
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

			obstacles[i].transform.localPosition  = GetPositionByDirection(dir)[0];
			obstacles[i].transform.localRotation = Quaternion.Euler(GetPositionByDirection(dir)[1]);

			if (obstacles[i].activeSelf)
			{
				availablePositionDirection.Remove(dir);
			}

		}


		Vector3 remainingLoc = GetPositionByDirection(availablePositionDirection[Random.Range(0, availablePositionDirection.Count)])[0];
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
