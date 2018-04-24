using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectorInfoHandler : MonoBehaviour {

	public enum ContainerType
	{
		Challenge,
		Buy,
	}

	public Image info_sprite;
	public Text info_desc;

	private CanvasGroup canvasGroup;
	private Image background;
	private StoreItem activeStoreItem;
	public GameObject challengeContainer;
	public GameObject buyContainer;


	void OnEnable()
	{
		EventManager.OnButtonClick += OnButtonClick;
	}
	void OnDisable()
	{
		EventManager.OnButtonClick -= OnButtonClick;
	}

	void Start ()
	{
		Initialize();
	}

	void Initialize()
	{
		background = GetComponent<Image>();
		HideContainers();
	}

	public void ShowContainer(ContainerType type, Package p)
	{
		HideContainers();
		background.enabled = true;
		p.challenge.UpdateValues();
		switch (type)
		{
			case ContainerType.Challenge:
			{
				challengeContainer.SetActive(true);
				challengeContainer.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = p.icon;
				challengeContainer.transform.GetChild(1).GetComponent<Text>().text = p.challenge.description + " [ " + p.challenge.progress + " / " + p.challenge.cap + " ] ";
				break;
			}
			case ContainerType.Buy:
			{
				buyContainer.SetActive(true);
				buyContainer.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = p.icon;
				buyContainer.transform.GetChild(1).GetComponent<Text>().text = "test stuff";

				break;
			}
		}
	}

	void OnButtonClick(ButtonID id)
	{
		if (id == ButtonID.InfoBuy)
		{
			if (ActiveStoreItem != null)
			{
				ActiveStoreItem.Select();
				ActiveStoreItem.Unlock();
				HideContainers();

			}
		}
	}

	public void HideContainers()
	{
		background.enabled = false;
		challengeContainer.SetActive(false);
		buyContainer.SetActive(false);
	}

	public StoreItem ActiveStoreItem
	{
		get {return activeStoreItem; }
		set {
			this.activeStoreItem = value;
		}
	}
}
