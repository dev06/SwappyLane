using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SimpleButtonHandler : ButtonEventHandler {


	public override void OnPointerClick(PointerEventData data)
	{
		switch (buttonID)
		{
			case ButtonID.Back:
			{
				//FindObjectOfType<CharacterSelector> ().HideSelector ();
				if (EventManager.OnStateChange != null)
				{
					EventManager.OnStateChange(State.MENU);
				}
				break;
			}

			case ButtonID.StartArea:
			{
				Controller.SetState(State.GAME);

				break;
			}

			case ButtonID.InfoClose:
			{
				FindObjectOfType<SelectorInfoHandler>().Hide();
				break;
			}
		}
	}
}
