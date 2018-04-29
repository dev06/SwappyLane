using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatRecordController : MonoBehaviour {

	public bool DeleteSave;

	public bool UnlockChallenges;

	public static StatRecordController Instance;

	public static int TotalGamesPlayed;
	public static int HighestLevelReached;
	public static int CoinsCollected;
	public static float MetersRolled;
	public static int BlocksBreaked;
	public static int SkinsUnlocked;

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

		CoinsCollected += CoinController.Instance.LevelCoins;

		SaveStats();
	}

	public void SaveStats()
	{
		PlayerPrefs.SetInt("TotalGamesPlayed", TotalGamesPlayed);
		PlayerPrefs.SetInt("HighestLevelReached", HighestLevelReached);
		PlayerPrefs.SetInt("ActiveSkin", CharacterSelector.ActiveSkinPackage.id);
		PlayerPrefs.SetInt("ActiveTheme", CharacterSelector.ActiveThemePackage.id);
		PlayerPrefs.SetInt("LastLevel", levelController.level.Index);
		PlayerPrefs.SetInt("CoinsCollected", CoinsCollected);

		PlayerPrefs.SetFloat("MetersRolled", MetersRolled);
		PlayerPrefs.SetInt("BlocksBreaked", BlocksBreaked);
		PlayerPrefs.SetInt("SkinsUnlocked", SkinsUnlocked);

	}

	public void LoadStats()
	{
		TotalGamesPlayed = PlayerPrefs.GetInt("TotalGamesPlayed");
		HighestLevelReached = PlayerPrefs.GetInt("HighestLevelReached");
		CoinsCollected = PlayerPrefs.HasKey("CoinsCollected") ? PlayerPrefs.GetInt("CoinsCollected") : 0;
		CharacterSelector.ActiveSkinPackage = PackageCreator.Skins[!PlayerPrefs.HasKey("ActiveSkin") ? 0 : (PlayerPrefs.GetInt("ActiveSkin")) - 1];
		CharacterSelector.ActiveThemePackage = PackageCreator.Theme[!PlayerPrefs.HasKey("ActiveTheme") ? 0 : (PlayerPrefs.GetInt("ActiveTheme")) - 1];
		MetersRolled = PlayerPrefs.HasKey("MetersRolled") ? PlayerPrefs.GetFloat("MetersRolled") : 0;
		BlocksBreaked = PlayerPrefs.HasKey("BlocksBreaked") ? PlayerPrefs.GetInt("BlocksBreaked") : 0;
		SkinsUnlocked = PlayerPrefs.HasKey("SkinsUnlocked") ? PlayerPrefs.GetInt("SkinsUnlocked") : 0;

	}
}
