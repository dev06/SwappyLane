using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
	NONE,
	MENU,
	GAME,
}

public class Controller : MonoBehaviour {

	public static Controller Instance;

	public static bool isGameOver;

	private int linkSize = 15;

	public static State GameState = State.MENU;

	void Awake()
	{
		SetState(State.MENU);
		if (Instance == null)
		{
			Instance = this;
		}

		isGameOver = false;

		Application.targetFrameRate = 60;
	}
	public GameObject link;

	private Vector3[] positions;



	private LinkController linkController;


	public List<GameObject> links = new List<GameObject>();


	void Start () {

		SpawnObstacle();

		linkController = LinkController.Instance;

		linkController.Initalize();

		FindObjectOfType<UserInterface>().Init();
	}

	void Update () {


	}


	public void SpawnObstacle()
	{
		int count = linkSize;
		for (int i = 0; i < count; i++)
		{
			GameObject clone = (GameObject)Instantiate(link) as GameObject;
			clone.transform.SetParent(FindObjectOfType<Platform>().transform);
			clone.transform.localPosition = new Vector3(0, 0, .5f);
			clone.transform.localScale = new Vector3(1, 1, clone.transform.localScale.z);
			links.Add(clone);
			if (i > 0)
			{
				clone.GetComponent<Link>().PrevLink = links[i - 1].GetComponent<Link>();
			}
		}
	}


	public Vector3 LastLinkPosition()
	{
		return new Vector3(0, 0, ((linkSize * .5f) / linkSize) * linkSize / 2f);
	}

	public static void SetState(State s)
	{
		GameState = s;

		if (EventManager.OnStateChange != null)
		{
			EventManager.OnStateChange(GameState);
		}
	}
}
