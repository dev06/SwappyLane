using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StorePanel : MonoBehaviour {

	public PanelType panelType;

	private CanvasGroup canvasGroup;

	private bool isActive;

	private PanelTitleHandler panelTitleHandler;

	public Transform content;

	private ScrollRect scrollView;

	public StoreItem activeStoreItem;

	void OnEnable()
	{
		EventManager.OnStoreItemClick += OnStoreItemClick;
		EventManager.OnStateChange += OnStateChange;
	}

	void OnDisable()
	{
		EventManager.OnStoreItemClick -= OnStoreItemClick;
		EventManager.OnStateChange -= OnStateChange;
	}

	void OnStoreItemClick(StoreItem s, Package p)
	{
		if (s.type.ToString() == panelType.ToString())
		{

			ShowCurrentSelector(s);
		}
	}

	void OnStateChange(State s)
	{
		if (s == State.CHARACTER_SELECTOR)
		{
			foreach (Transform t in content)
			{
				t.GetComponent<StoreItem>().DoDance();
			}
		}
	}


	public void Init()
	{
		canvasGroup = GetComponent<CanvasGroup>();

		scrollView = transform.GetChild(0).GetComponent<ScrollRect>();

		
		GenerateElements(panelType);

		if (panelType == PanelType.Skins)
		{
			Show();
		}
	}

	private void GenerateElements(PanelType type)
	{
		int countPerRow = 3;
		float size = scrollView.transform.GetComponent<RectTransform>().sizeDelta.x / countPerRow;
		int yRow = 0;
		int xRow = 0;
		float multiplier = .9f;
		float ySize = 0;
		int length = (type == PanelType.Skins ? PackageCreator.Skins.Length : PackageCreator.Theme.Length);
		float yOffset = size / 40f; 
		for (int i = 0; i < length;  i++)
		{
			GameObject clone = Instantiate(AppResources.StoreIconTemplate) as GameObject;
			clone.transform.SetParent(content);

			RectTransform rt = clone.GetComponent<RectTransform>();
			if (i % countPerRow == 0 && i > 0)
			{
				yRow++;
				xRow = 0;
				ySize += size;
			}
			rt.sizeDelta = new Vector2(size * multiplier, size * multiplier );

			rt.anchoredPosition = new Vector2((xRow * size) + (size * (1f - multiplier)) / 2f  , (-yRow * size) - yOffset);
			rt.localScale = new Vector3(1, 1, 1);

			xRow++;

			StoreItem s = clone.GetComponent<StoreItem>();
			s.SetPackage(type == PanelType.Skins ? PackageCreator.Skins[i] : PackageCreator.Theme[i]);
			s.Initalize();
		}

		
		CharacterSelector.CheckForSkinUnlocks(); 

		RectTransform contentRect = content.GetComponent<RectTransform> ();

		contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, (ySize + size)  + yOffset);
	}

	private void ShowCurrentSelector(StoreItem item)
	{

		foreach (Transform t in content)
		{
			t.GetComponent<StoreItem>().Hide();
		}

		item.Show();

		activeStoreItem = item;

	}

	public void Show()
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}

		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;

		IsActive = true;


		panelTitleHandler.ManageIndicator(true);

	}

	public void Hide()
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}

		canvasGroup.alpha = 0f;
		canvasGroup.blocksRaycasts = false;

		IsActive = false;


		panelTitleHandler.ManageIndicator(false);

	}

	public bool IsActive
	{
		get {
			return isActive;
		}

		set {
			this.isActive = value;
		}
	}

	public void SetPanelTitleHandler(PanelTitleHandler p)
	{
		this.panelTitleHandler = p;
	}
}
