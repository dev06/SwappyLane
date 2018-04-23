using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class StoreItem : ButtonEventHandler {

	private Package package;

	private Image icon;

	public Image status;

	public Sprite padlock;
	public Sprite selected;

	public GameObject progression;

	private Image progression_progress;


	public void Initalize()
	{
		progression_progress = progression.transform.GetChild(1).GetComponent<Image>();

		if (package != null)
		{
			icon = GetComponent<Image>();
			icon.sprite = package.model.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;

			if (package.challenge != null)
			{
				package.challenge.RefreshCompletion();

				if (package.challenge.completed)
				{
					progression.SetActive(false);
				}
				else
				{

					//	progression_progress.fillAmount = package.challenge.progress / package.challenge.cap;
				}
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

	public void SetPackage(Package p)
	{
		this.package = p;
	}

	public override void OnPointerClick(PointerEventData data)
	{
		SelectorInfoHandler infoHandler = FindObjectOfType<SelectorInfoHandler>();

		if (package.challenge != null)
		{
			if (package.challenge.completed == false)
			{
				FindObjectOfType<SelectorInfoHandler>().Show(package);
			}
			else
			{
				if (EventManager.OnStoreItemClick != null)
				{
					EventManager.OnStoreItemClick(this, package);
				}

				status.enabled = true;
			}
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
