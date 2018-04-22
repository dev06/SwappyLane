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

	void Start ()
	{
		Init();
	}

	private void Init()
	{
		canvasGroup = GetComponent<CanvasGroup>();

		scrollView = transform.GetChild(0).GetComponent<ScrollRect>();

		GenerateElements();
	}

	private void GenerateElements()
	{
		int countPerRow = 3;
		float size = scrollView.transform.GetComponent<RectTransform>().sizeDelta.x / countPerRow;
		int yRow = 0;
		int xRow = 0;
		float multiplier = .85f;
		float ySize = 0;
		for (int i = 0; i < 36; i++)
		{
			GameObject clone = Instantiate(AppResources.StoreIconTemplate) as GameObject;
			clone.transform.SetParent(content);

			RectTransform rt = clone.GetComponent<RectTransform>();
			if (i % countPerRow == 0 && i > 0)
			{
				yRow++;
				xRow = 0;
			}
			rt.sizeDelta = new Vector2(size * multiplier, size * multiplier );

			rt.anchoredPosition = new Vector2((xRow * size) + (size * (1f - multiplier)) / 2f  , -yRow * size);

			rt.localScale = new Vector3(1, 1, 1);
			ySize += size;
			xRow++;

			StoreItem s = clone.GetComponent<StoreItem>();
			s.SetPackage(CharacterSelector.GetPackage(i));
			s.Initalize();
		}

		RectTransform contentRect = content.GetComponent<RectTransform> ();
		contentRect.sizeDelta = new Vector2(contentRect.sizeDelta.x, (ySize / countPerRow));
	}

	void Update()
	{
		//Debug.Log ("test");
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
