using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CharacterButton : ButtonEventHandler {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//Debug.Log("fasdf");
	}

	public override void OnPointerClick(PointerEventData data)
	{
		if (EventManager.OnStateChange != null)
		{
			EventManager.OnStateChange(State.CHARACTER_SELECTOR);
		}
		//FindObjectOfType<CharacterSelector> ().ShowSelector ();
	}


	public override void OnPointerDown(PointerEventData data)
	{
		//Debug.Log("Charactersasdfasf");
	}
}
