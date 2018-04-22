using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public enum ButtonID
{
	None,
	Setting,
	Characters,
	StartArea,
	Back,
	StoreItem,
}
public class ButtonEventHandler : MonoBehaviour, IPointerClickHandler, IPointerDownHandler  {

	public ButtonID buttonID;
	void Start () {

	}

	void Update () {

	}

	public virtual void OnPointerClick(PointerEventData data)
	{

	}

	public virtual void OnPointerDown(PointerEventData data)
	{

	}
}
