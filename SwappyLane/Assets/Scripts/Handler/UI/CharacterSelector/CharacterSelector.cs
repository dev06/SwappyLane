﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PanelType
{
	Skins,
	Theme,
}

public enum PackageType
{
	Skins,
	Theme,
}

public class Package
{
	public int id;
	public GameObject model;
	public Challenge challenge;
	public Purchase purchase;
	public bool defaultPackage;
	public Sprite icon;
	public PackageType type;

	public Package(GameObject model)
	{
		this.model = model;

	}

	public Package(PackageType type, int id, GameObject model, Challenge challenge)
	{
		this.type = type;
		this.id = id;
		this.model = model;
		this.challenge = challenge;
		SetSprite();
	}
	public Package(PackageType type, int id, GameObject model, Purchase purchase)
	{
		this.type = type;
		this.id = id;
		this.purchase = purchase;
		this.model = model;
		this.purchase.id = id;
		this.purchase.IsPurchased = PlayerPrefs.HasKey("theme_" + id) ? bool.Parse(PlayerPrefs.GetString("theme_" + id)) : false;
		SetSprite();
	}
	public Package(PackageType type, int id, GameObject model, bool defaultPackage)
	{
		this.type = type;
		this.id = id;
		this.defaultPackage = defaultPackage;
		this.model = model;
		this.challenge = new Challenge(ChallengeType.None);
		SetSprite();
	}




	private void SetSprite()
	{
		switch (type)
		{
			case PackageType.Skins:
			{
				icon = model.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
				break;
			}

			case PackageType.Theme:
			{
				icon = model.transform.GetChild(2).GetComponent<SpriteRenderer>().sprite;
				break;
			}
		}
	}

}

public enum ChallengeType
{
	None,
	PlayGame, 		// play game x times
	LevelReach, 	// reach x level
	Roll, 			// roll x meters
	BreakBlock, 	// break x blocks
	UnlockSkins, 	// unlock x skins

}

public class Challenge
{
	public bool completed;
	public ChallengeType type;
	public string description;
	public float progress;
	public float cap;

	public Challenge(ChallengeType type)
	{
		this.type = type;
		completed = true;
	}

	public Challenge( ChallengeType type, float cap)
	{
		this.cap = cap;
		this.type = type;
		SetDesription();
		UpdateCompletion();
	}

	public void UpdateValues()
	{
		switch (type)
		{
			case ChallengeType.PlayGame:
			{
				progress = StatRecordController.TotalGamesPlayed;
				break;
			}

			case ChallengeType.LevelReach:
			{
				progress = StatRecordController.HighestLevelReached;
				break;
			}

			case ChallengeType.BreakBlock:
			{
				progress = StatRecordController.BlocksBreaked;
				break;
			}
			case ChallengeType.Roll:
			{
				progress =  Mathf.Round(StatRecordController.MetersRolled * 100f) / 100f;
				break;
			}
			case ChallengeType.UnlockSkins:
			{
				progress = StatRecordController.SkinsUnlocked;
				break;
			}
		}
	}

	private void UpdateCompletion()
	{
		completed = StatRecordController.Instance.UnlockChallenges;
	}

	private void SetDesription()
	{
		switch (type)
		{
			case ChallengeType.PlayGame: description = "Play " + cap + " games"; break;
			case ChallengeType.LevelReach: description = "Reach Level " + cap; break;
			case ChallengeType.Roll: description = "Roll " + cap + " meters"; break;
			case ChallengeType.BreakBlock: description = "Break " + cap + " blocks"; break;
			case ChallengeType.UnlockSkins: description = "Unlock " + cap + " Skins in total"; break;
		}
	}

	public void RefreshCompletion()
	{
		UpdateValues();
		if (progress >= cap)
		{
			completed = true;
		}
	}
}

public class Purchase
{
	public int id;
	public bool purchased;
	public string description;
	public float cost;

	public Purchase(float cost)
	{
		this.cost = cost;
		description = "Unlock for " + cost + " gems";
		RefreshPurchased();
	}

	public void RefreshPurchased()
	{
		purchased = PlayerPrefs.HasKey("theme_" + id) ? bool.Parse(PlayerPrefs.GetString("theme_" + id)) : false;
	}

	public bool IsPurchased
	{
		get {
			return purchased;
		}

		set {
			this.purchased = value;
		}
	}
}

public class CharacterSelectorEvent
{
	public delegate void PanelClick(PanelType p);
	public static PanelClick OnPanelClick;
}

public class PackageCreator
{

	public static Challenge challenge_playgame_1 = new Challenge(ChallengeType.PlayGame, 5);
	public static Challenge challenge_playgame_2 = new Challenge(ChallengeType.PlayGame, 7);
	public static Challenge challenge_playgame_3 = new Challenge(ChallengeType.PlayGame, 9);
	public static Challenge challenge_playgame_4 = new Challenge(ChallengeType.PlayGame, 11);
	public static Challenge challenge_playgame_5 = new Challenge(ChallengeType.PlayGame, 13);
	public static Challenge challenge_playgame_6 = new Challenge(ChallengeType.PlayGame, 15);

	public static Challenge challenge_levelreach_1 = new Challenge(ChallengeType.LevelReach, 1);
	public static Challenge challenge_levelreach_2 = new Challenge(ChallengeType.LevelReach, 2);
	public static Challenge challenge_levelreach_3 = new Challenge(ChallengeType.LevelReach, 3);
	public static Challenge challenge_levelreach_4 = new Challenge(ChallengeType.LevelReach, 4);
	public static Challenge challenge_levelreach_5 = new Challenge(ChallengeType.LevelReach, 25);
	public static Challenge challenge_levelreach_6 = new Challenge(ChallengeType.LevelReach, 30);

	public static Challenge challenge_roll_1 = new Challenge(ChallengeType.Roll, 2);
	public static Challenge challenge_roll_2 = new Challenge(ChallengeType.Roll, 3);
	public static Challenge challenge_roll_3 = new Challenge(ChallengeType.Roll, 4);
	public static Challenge challenge_roll_4 = new Challenge(ChallengeType.Roll, 5);
	public static Challenge challenge_roll_5 = new Challenge(ChallengeType.Roll, 25);
	public static Challenge challenge_roll_6 = new Challenge(ChallengeType.Roll, 30);

	public static Challenge challenge_breakblock_1 = new Challenge(ChallengeType.BreakBlock, 5);
	public static Challenge challenge_breakblock_2 = new Challenge(ChallengeType.BreakBlock, 7);
	public static Challenge challenge_breakblock_3 = new Challenge(ChallengeType.BreakBlock, 9);
	public static Challenge challenge_breakblock_4 = new Challenge(ChallengeType.BreakBlock, 11);
	public static Challenge challenge_breakblock_5 = new Challenge(ChallengeType.BreakBlock, 13);
	public static Challenge challenge_breakblock_6 = new Challenge(ChallengeType.BreakBlock, 15);

	public static Challenge challenge_unlockskins_1 = new Challenge(ChallengeType.UnlockSkins, 5);
	public static Challenge challenge_unlockskins_2 = new Challenge(ChallengeType.UnlockSkins, 7);
	public static Challenge challenge_unlockskins_3 = new Challenge(ChallengeType.UnlockSkins, 9);
	public static Challenge challenge_unlockskins_4 = new Challenge(ChallengeType.UnlockSkins, 20);
	public static Challenge challenge_unlockskins_5 = new Challenge(ChallengeType.UnlockSkins, 25);
	public static Challenge challenge_unlockskins_6 = new Challenge(ChallengeType.UnlockSkins, 30);

	public static Purchase purchase_1 = new Purchase(4);
	public static Purchase purchase_2 = new Purchase(4);
	public static Purchase purchase_3 = new Purchase(4);
	public static Purchase purchase_4 = new Purchase(4);
	public static Purchase purchase_5 = new Purchase(4);
	public static Purchase purchase_6 = new Purchase(4);
	public static Purchase purchase_7 = new Purchase(4);
	public static Purchase purchase_8 = new Purchase(4);
	public static Purchase purchase_9 = new Purchase(3);


	public static Package[] Skins =
	{
		new Package(PackageType.Skins, 1, AppResources.char_1, true),
		new Package(PackageType.Skins, 2, AppResources.char_2, challenge_playgame_1),
		new Package(PackageType.Skins, 3, AppResources.char_3, challenge_levelreach_1),
		new Package(PackageType.Skins, 4, AppResources.char_4, challenge_roll_1),
		new Package(PackageType.Skins, 5, AppResources.char_5, challenge_breakblock_1),
		new Package(PackageType.Skins, 6, AppResources.char_6, challenge_unlockskins_1),
		new Package(PackageType.Skins, 7, AppResources.char_7, challenge_playgame_2),
		new Package(PackageType.Skins, 8, AppResources.char_8, challenge_levelreach_2),
		new Package(PackageType.Skins, 9, AppResources.char_9, challenge_roll_2),
		new Package(PackageType.Skins, 10, AppResources.char_10, challenge_breakblock_2),
		new Package(PackageType.Skins, 11, AppResources.char_11, challenge_unlockskins_2),
		new Package(PackageType.Skins, 12, AppResources.char_12, challenge_playgame_3),
		new Package(PackageType.Skins, 13, AppResources.char_13, challenge_roll_3),
		new Package(PackageType.Skins, 14, AppResources.char_14, challenge_breakblock_3),
		new Package(PackageType.Skins, 15, AppResources.char_15, challenge_unlockskins_3),
		new Package(PackageType.Skins, 16, AppResources.char_16, challenge_playgame_4),
		new Package(PackageType.Skins, 17, AppResources.char_17, challenge_roll_4),

	};

	public static Package[] Theme =
	{
		new Package(PackageType.Theme, 1, AppResources.theme_1, true),
		new Package(PackageType.Theme, 2, AppResources.theme_2, purchase_1),
		new Package(PackageType.Theme, 3, AppResources.theme_3, purchase_2),
		new Package(PackageType.Theme, 4, AppResources.theme_4, purchase_3),
		new Package(PackageType.Theme, 5, AppResources.theme_5, purchase_4),
		new Package(PackageType.Theme, 6, AppResources.theme_6, purchase_5),
		new Package(PackageType.Theme, 7, AppResources.theme_7, purchase_6),
		new Package(PackageType.Theme, 8, AppResources.theme_8, purchase_7),
		new Package(PackageType.Theme, 9, AppResources.theme_9, purchase_8),
		new Package(PackageType.Theme, 10, AppResources.theme_10, purchase_9),
		new Package(PackageType.Theme, 11, AppResources.theme_11, purchase_9),
		new Package(PackageType.Theme, 12, AppResources.theme_12, purchase_9),

	};
}
public class CharacterSelector : UserInterface
{

	public List<StorePanel> panels;

	public static List<StoreItem> SkinItems = new List<StoreItem>();

	public Text coinHudText;

	private CanvasGroup canvasGroup;

	public static Package ActiveSkinPackage;
	public static Package ActiveThemePackage;

	void OnEnable()
	{
		CharacterSelectorEvent.OnPanelClick += OnPanelClick;
		EventManager.OnStateChange += OnStateChange;
		EventManager.OnGameOver += OnGameOver;
	}
	void OnDisable()
	{
		CharacterSelectorEvent.OnPanelClick -= OnPanelClick;
		EventManager.OnStateChange -= OnStateChange;
		EventManager.OnGameOver -= OnGameOver;
	}

	void OnPanelClick(PanelType type)
	{
		ShowPanel(type);
	}

	void OnStateChange(State s)
	{
		if (s != State.CHARACTER_SELECTOR)
		{
			HideSelector();
			return;
		}
		UpdateSelectorUI();
		ShowSelector();
		CheckForSkinUnlocks();
	}

	void OnGameOver()
	{
		SkinItems.Clear();
	}

	void Start()
	{
		panels = new List<StorePanel>();

		canvasGroup = GetComponent<CanvasGroup> ();

		for (int i = 0; i < transform.childCount; i++)
		{
			StorePanel sp = transform.GetChild(i).GetComponent<StorePanel>();
			if (sp == null) {
				continue;
			}
			panels.Add(transform.GetChild(i).GetComponent<StorePanel>());
		}

		HideSelector ();

	}
	public override void Init()
	{
		base.Init();
	}

	public void ShowPanel(PanelType p)
	{
		HideAll();

		foreach (StorePanel sp in panels)
		{
			if (sp.panelType == p)
			{
				sp.Show();
				break;
			}
		}

	}

	public static void CheckForSkinUnlocks()
	{
		int count = 0;

		for (int i = 0; i < SkinItems.Count; i++)
		{
			SkinItems[i].Package.challenge.RefreshCompletion();

			if (SkinItems[i].Package.challenge.completed == true)
			{
				count++;
			}
		}

		StatRecordController.SkinsUnlocked = count;

		for (int i = 0; i < SkinItems.Count; i++)
		{
			SkinItems[i].Package.challenge.RefreshCompletion();

			if (SkinItems[i].Package.challenge.completed == true)
			{
				SkinItems[i].DeactiveProgression();
			}
		}


		//Debug.Log(SkinItems.Count);
		//Debug.Log("Total Skins Unlocked " + StatRecordController.SkinsUnlocked);
		// for (int i = 0 ; i < SkinItems.Count; i++)
		// {
		// 	if (SkinItems[i].Package.challenge == null) continue;
		// 	if (SkinItems[i].Package.challenge.type != ChallengeType.UnlockSkins) continue;
		// 	if (count >= SkinItems[i].Package.challenge.cap)
		// 	{

		// 	}
		// }
	}

	public void HideAll()
	{
		foreach (StorePanel sp in panels)
		{
			sp.Hide();
		}
	}

	public void HideSelector()
	{
		if (canvasGroup == null) {
			canvasGroup = GetComponent<CanvasGroup> ();
		}

		canvasGroup.alpha = 0;
		canvasGroup.blocksRaycasts = false;
	}

	public void ShowSelector()
	{
		if (canvasGroup == null) {
			canvasGroup = GetComponent<CanvasGroup> ();
		}
		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;
	}

	public void UpdateSelectorUI()
	{
		coinHudText.text = StatRecordController.CoinsCollected.ToString();
	}
}
