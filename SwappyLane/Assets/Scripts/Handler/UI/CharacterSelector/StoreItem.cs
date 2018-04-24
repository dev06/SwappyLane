using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class StoreItem : ButtonEventHandler {

	private Package package;

	public PackageType type;
	private Image icon;

	public Image status;

	public Sprite padlock;
	public Sprite selected;

	public GameObject progression;

	private Image progression_progress;

	public bool defaultItem;




	public void Initalize()
	{
		progression_progress = progression.transform.GetChild(1).GetComponent<Image>();

		if (package != null)
		{
			icon = GetComponent<Image>();
			icon.sprite = package.icon;

			if (StatRecordController.Instance.UnlockChallenges)
			{
				Unlock();
			}

			if (package.defaultPackage)
			{
				Unlock();
			}

			if (package.challenge != null)
			{
				package.challenge.RefreshCompletion();

				if (package.challenge.completed)
				{
					progression.SetActive(false);
				}
			}

			type = package.type;
		}

		Hide();

		if (package.type == PackageType.Skins)
		{
			if (CharacterSelector.ActiveSkinPackage.id == package.id)
			{
				Show();
			}
		}

		if (package.type == PackageType.Theme)
		{
			if (CharacterSelector.ActiveThemePackage.id == package.id)
			{
				Show();
			}
		}


	}

	public void DoDance()
	{
		StopCoroutine("Animate");
		progression_progress.fillAmount = 0;
		if (progression.activeSelf == false) { return; }
		if (package == null || package.challenge == null) { return; }
		StartCoroutine("Animate");
	}

	IEnumerator Animate()
	{
		float vel = 0;
		while (true)
		{
			progression_progress.fillAmount = Mathf.SmoothDamp(progression_progress.fillAmount, package.challenge.progress / package.challenge.cap,
			                                  ref vel, Time.deltaTime * 20f);


			yield return null;
		}
	}

	public void Unlock()
	{
		progression.SetActive(false);
		if (package.challenge != null)
		{
			package.challenge.completed = true;
		}

		if (package.type == PackageType.Theme)
		{
			PlayerPrefs.SetString("theme_" + package.id, "True");
		}

	}

	public void SetPackage(Package p)
	{
		this.package = p;
	}

	public override void OnPointerClick(PointerEventData data)
	{
		SelectorInfoHandler infoHandler = FindObjectOfType<SelectorInfoHandler>();
		infoHandler.ActiveStoreItem = this;
		if (package.challenge != null)
		{
			if (package.challenge.completed == false)
			{
				switch (type)
				{
					case PackageType.Skins:
					{
						infoHandler.ShowContainer(SelectorInfoHandler.ContainerType.Challenge, package);
						break;
					}
					case PackageType.Theme:
					{
						infoHandler.ShowContainer(SelectorInfoHandler.ContainerType.Buy, package);
						break;
					}
				}
			}
			else
			{
				Select();
			}
		}
		else
		{
			Select();
		}
	}

	public void Select()
	{
		if (EventManager.OnStoreItemClick != null)
		{
			EventManager.OnStoreItemClick(this, package);
		}

		status.enabled = true;


		if (package.type == PackageType.Skins)
		{
			CharacterSelector.ActiveSkinPackage = package;
		}

		if (package.type == PackageType.Theme)
		{
			CharacterSelector.ActiveThemePackage = package;
		}


	}

	public void Show()
	{
		status.enabled = true;
	}

	public void Hide()
	{
		status.enabled = false;
	}
}
