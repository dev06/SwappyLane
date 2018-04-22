using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class StoreItem : MonoBehaviour {

	private Package package;
	private Image icon; 
	public void Initalize()
	{
		if(package != null)
		{
			icon = GetComponent<Image>(); 
			icon.sprite = package.model.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite; 
		}
	}

	public void SetPackage(Package p)
	{
		this.package = p;
	}
}
