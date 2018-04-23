using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PanelType
{
	Skins,
	Theme,
}

public class Package
{

	public GameObject model;
	public Challenge challenge;

	public Package(GameObject model)
	{
		this.model = model;

	}

	public Package(GameObject model, Challenge challenge)
	{
		this.model = model;
		this.challenge = challenge;
	}

}

public enum ChallengeType
{
	None,
	PlayGame,
	LevelReach,
}

public class Challenge
{
	public bool completed;
	public ChallengeType type;
	public string description;
	public float progress;
	public float cap;

	public Challenge( ChallengeType type, float cap)
	{
		this.cap = cap;
		this.type = type;
		SetDesription();
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
		}
	}

	private void SetDesription()
	{
		switch (type)
		{
			case ChallengeType.PlayGame: description = "Play " + cap + " games"; break;
			case ChallengeType.LevelReach: description = "Reach Level " + cap; break;
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

	public static Challenge challenge_levelreach_1 = new Challenge(ChallengeType.LevelReach, 5);
	public static Challenge challenge_levelreach_2 = new Challenge(ChallengeType.LevelReach, 10);
	public static Challenge challenge_levelreach_3 = new Challenge(ChallengeType.LevelReach, 15);
	public static Challenge challenge_levelreach_4 = new Challenge(ChallengeType.LevelReach, 20);
	public static Challenge challenge_levelreach_5 = new Challenge(ChallengeType.LevelReach, 25);
	public static Challenge challenge_levelreach_6 = new Challenge(ChallengeType.LevelReach, 30);

	public static Package[] Skins =
	{
		new Package(AppResources.char_1),
		new Package(AppResources.char_2, challenge_playgame_1),
		new Package(AppResources.char_3, challenge_playgame_2),
		new Package(AppResources.char_4, challenge_playgame_3),
		new Package(AppResources.char_5, challenge_playgame_4),
		new Package(AppResources.char_6, challenge_playgame_5),
		new Package(AppResources.char_7, challenge_playgame_6),
		new Package(AppResources.char_8, challenge_levelreach_1),
		new Package(AppResources.char_9, challenge_levelreach_2),
		new Package(AppResources.char_10, challenge_levelreach_3),
		new Package(AppResources.char_11, challenge_levelreach_4),
		new Package(AppResources.char_12, challenge_levelreach_5),
		new Package(AppResources.char_13, challenge_levelreach_6),
	};

	public static Package[] Theme =
	{

	};
}
public class CharacterSelector : UserInterface
{

	public List<StorePanel> panels;

	private CanvasGroup canvasGroup;

	void OnEnable()
	{
		CharacterSelectorEvent.OnPanelClick += OnPanelClick;
		EventManager.OnStateChange += OnStateChange;
	}
	void OnDisable()
	{
		CharacterSelectorEvent.OnPanelClick -= OnPanelClick;
		EventManager.OnStateChange -= OnStateChange;
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

		ShowSelector();
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
		//HideAll();
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
}
