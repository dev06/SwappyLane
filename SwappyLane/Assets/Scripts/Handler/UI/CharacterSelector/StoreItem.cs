using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreItem : MonoBehaviour {

	private Package package;

	public void Initalize()
	{
		Debug.Log(package.model);
	}

	public void SetPackage(Package p)
	{
		this.package = p;
	}
}
