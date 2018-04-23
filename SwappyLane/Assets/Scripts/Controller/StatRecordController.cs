using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatRecordController : MonoBehaviour {

	public bool DeleteSave;

	public static StatRecordController Instance;

	public static int TotalGamesPlayed;
	public static int HighestLevelReached;

	private LevelController levelController;


	void Awake()
	{
		if (Instance == null)
		{
			Instance = this;
		}


		if (DeleteSave)
		{
			PlayerPrefs.DeleteAll();
		}

		LoadStats();
	}

	void OnEnable()
	{
		EventManager.OnStateChange += OnStateChange;
		EventManager.OnGameOver += OnGameOver;
	}

	void OnDisable()
	{
		EventManager.OnStateChange -= OnStateChange;
		EventManager.OnGameOver -= OnGameOver;
	}

	public void Initialize()
	{
		levelController = LevelController.Instance;

	}


	void OnStateChange(State s)
	{
		if (s == State.GAME)
		{
			TotalGamesPlayed++;
		}
	}

	void OnGameOver()
	{
		int lastLevelAchieved = levelController.level.Index;

		if (lastLevelAchieved > HighestLevelReached)
		{
			HighestLevelReached = lastLevelAchieved;
		}

		SaveStats();
	}

	public void SaveStats()
	{
		PlayerPrefs.SetInt("TotalGamesPlayed", TotalGamesPlayed);
		PlayerPrefs.SetInt("HighestLevelReached", HighestLevelReached);
	}

	public void LoadStats()
	{
		TotalGamesPlayed = PlayerPrefs.GetInt("TotalGamesPlayed");
		HighestLevelReached = PlayerPrefs.GetInt("HighestLevelReached");
	}
}
