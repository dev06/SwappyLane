using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class PanelTitleHandler : MonoBehaviour, IPointerClickHandler {

	public StorePanel panel;

	private Image activeIndicator;

	void Start ()
	{
		activeIndicator = GetComponentInChildren<Image>();

		panel.SetPanelTitleHandler(this);
	}


	void Update () {
//		Debug.Log("asdf");
	}

	public virtual void OnPointerClick(PointerEventData data)
	{
		if (CharacterSelectorEvent.OnPanelClick != null)
		{
			CharacterSelectorEvent.OnPanelClick(panel.panelType);
		}
	}


	public void ManageIndicator(bool b)
	{
		activeIndicator.enabled = b;
	}
}
