using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems; 
public class SimpleButtonHandler : ButtonEventHandler {

		
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnPointerClick(PointerEventData data)
	{
		switch (buttonID) 
		{
		case ButtonID.Back: 
			{
				FindObjectOfType<CharacterSelector> ().HideSelector (); 
				break; 
			}

		case ButtonID.StartArea: 
			{
				Controller.SetState(State.GAME);
		
				break; 
			}
		}
	}
}
