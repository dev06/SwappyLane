using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class StoreItem : ButtonEventHandler {

	private Package package;

	private Image icon;

	public void Initalize()
	{
		if (package != null)
		{
			icon = GetComponent<Image>();
			icon.sprite = package.model.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
		}
	}

	public void SetPackage(Package p)
	{
		this.package = p;
	}

	public override void OnPointerClick(PointerEventData data)
	{
		if (EventManager.OnStoreItemClick != null)
		{
			EventManager.OnStoreItemClick(package);
		}
	}
}
