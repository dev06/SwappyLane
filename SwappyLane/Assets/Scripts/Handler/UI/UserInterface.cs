﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInterface : MonoBehaviour {

	public bool showInEditor;

	protected CanvasGroup group;

	public virtual void Init()
	{
		group = GetComponent<CanvasGroup>();
	}

	void OnValidate()
	{
		if (group == null)
		{
			group = GetComponent<CanvasGroup>();
		}

		group.alpha = showInEditor ? 1 : 0;
		group.blocksRaycasts = showInEditor;
	}


	public virtual void Show()
	{
		group.alpha = 1;
		group.blocksRaycasts = true;
	}

	public virtual void Hide()
	{
		group.alpha = 0f;
		group.blocksRaycasts = false;
	}




}