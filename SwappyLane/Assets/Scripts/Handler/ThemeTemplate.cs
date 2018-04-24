using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeTemplate : MonoBehaviour {

	private GameObject activeModel;
	private Controller controller;

	void Start ()
	{
		controller = Controller.Instance;
		if (activeModel == null)
		{
			activeModel = CharacterSelector.ActiveThemePackage.model;
			CreateTheme(activeModel);
		}
	}

	void OnEnable()
	{
		EventManager.OnStoreItemClick += OnStoreItemClick;
	}
	void OnDisable()
	{
		EventManager.OnStoreItemClick -= OnStoreItemClick;
	}

	void OnStoreItemClick(StoreItem s, Package p)
	{
		if (p == null) { return; }
		if (p.type != PackageType.Theme) { return; }
		activeModel = p.model;
		CreateTheme(activeModel);
		controller.SpawnLink();
	}


	public void CreateTheme(GameObject template)
	{
		foreach (Transform t in transform)
		{
			Destroy(t.gameObject);
		}
		GameObject clone =  (GameObject)Instantiate(template) as GameObject;
		clone.transform.GetChild(0).SetParent(transform);
		Destroy(clone);
	}
}
