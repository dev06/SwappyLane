using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeTemplate : MonoBehaviour {

	private GameObject activeModel;
	private Controller controller;
	private LinkController linkController;

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
		EventManager.OnObstacleHit += OnObstacleHit;
	}
	void OnDisable()
	{
		EventManager.OnStoreItemClick -= OnStoreItemClick;
		EventManager.OnObstacleHit -= OnObstacleHit;
	}

	void OnStoreItemClick(StoreItem s, Package p)
	{
		if (p == null) { return; }
		if (p.type != PackageType.Theme) { return; }
		activeModel = p.model;
		CreateTheme(activeModel);
		controller.SpawnLink();
	}

	void OnObstacleHit(GameObject o)
	{
		if (LinkController.Instance.AtTerminalVelocity)
		{
			transform.GetChild(1).transform.position = o.transform.position;
			transform.GetChild(1).GetComponent<ParticleSystem>().Play();
		}
	}


	public void CreateTheme(GameObject template)
	{
		foreach (Transform t in transform)
		{
			Destroy(t.gameObject);
		}
		GameObject clone =  (GameObject)Instantiate(template) as GameObject;
		clone.transform.GetChild(0).SetParent(transform);
		clone.transform.GetChild(4).SetParent(transform);
		Destroy(clone);
	}
}
