using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTemplate : MonoBehaviour {

	private GameObject activeModel;

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
		activeModel = p.model;
		CreateCharacter(activeModel);
	}
	void Start()
	{
		if (activeModel == null)
		{
			activeModel = AppResources.char_1;
			CreateCharacter(activeModel);
		}
	}

	public void CreateCharacter(GameObject template)
	{
		foreach (Transform t in transform)
		{
			Destroy(t.gameObject);
		}
		GameObject clone = Instantiate(template) as GameObject;
		clone.transform.GetChild(2).SetParent(transform);
		clone.transform.GetChild(1).SetParent(transform);
		clone.transform.GetChild(0).SetParent(transform);
		Destroy(clone);
	}
}
