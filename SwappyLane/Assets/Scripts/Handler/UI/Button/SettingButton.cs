using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SettingButton : ButtonEventHandler {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public override void OnPointerClick(PointerEventData data)
	{
		base.OnPointerClick(data);
		Debug.Log("Settings");

	}
}
