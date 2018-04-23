using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectorInfoHandler : MonoBehaviour {

	public Image info_sprite;
	public Text info_desc;

	private CanvasGroup canvasGroup;

	void Start ()
	{
		Initialize();
	}

	void Initialize()
	{
		Hide();
	}

	private void SetValues(Package p)
	{
		p.challenge.UpdateValues();
		info_sprite.sprite = p.model.transform.GetChild(3).GetComponent<SpriteRenderer>().sprite;
		info_desc.text = p.challenge.description + " [ " + p.challenge.progress + " / " + p.challenge.cap + " ] ";
	}

	public void Show(Package p)
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}

		canvasGroup.alpha = 1f;
		canvasGroup.blocksRaycasts = true;

		SetValues(p);
	}

	public void Hide()
	{
		if (canvasGroup == null)
		{
			canvasGroup = GetComponent<CanvasGroup>();
		}

		canvasGroup.alpha = 0f;
		canvasGroup.blocksRaycasts = false;
	}
}
