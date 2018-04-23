﻿using System.Collections;
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

	public Package(GameObject model)
	{
//		Debug.Log("Mode" + model);
		this.model = model;
	}

}

public class CharacterSelectorEvent
{
	public delegate void PanelClick(PanelType p);
	public static PanelClick OnPanelClick;
}
public class CharacterSelector : MonoBehaviour {

	public static Package GetPackage(int i)
	{
		switch (i)
		{
			case 1:
				return new Package(AppResources.char_1);
			case 2:
				return new Package(AppResources.char_2);
			case 3:
				return new Package(AppResources.char_3);
			case 4:
				return new Package(AppResources.char_4);
			case 5:
				return new Package(AppResources.char_5);
			case 6:
				return new Package(AppResources.char_6);
			case 7:
				return new Package(AppResources.char_7);
			case 8:
				return new Package(AppResources.char_8);
			case 9:
				return new Package(AppResources.char_9);
			case 10:
				return new Package(AppResources.char_10);
			case 11:
				return new Package(AppResources.char_11);
			case 12:
				return new Package(AppResources.char_12);
		}

		return null;
	}

	public List<StorePanel> panels;

	private CanvasGroup canvasGroup;

	void OnEnable()
	{
		CharacterSelectorEvent.OnPanelClick += OnPanelClick;
	}
	void OnDisable()
	{
		CharacterSelectorEvent.OnPanelClick -= OnPanelClick;
	}

	void OnPanelClick(PanelType type)
	{
		ShowPanel(type);
	}

	void Start()
	{
		panels = new List<StorePanel>();

		canvasGroup = GetComponent<CanvasGroup> ();

		for (int i = 2; i < transform.childCount; i++)
		{
			panels.Add(transform.GetChild(i).GetComponent<StorePanel>());
		}

		HideSelector ();
		HideAll();
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
