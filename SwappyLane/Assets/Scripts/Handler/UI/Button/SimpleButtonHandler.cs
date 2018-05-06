using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SimpleButtonHandler : ButtonEventHandler {

	public override void OnPointerDown(PointerEventData data)
	{
		switch (buttonID)
		{
			case ButtonID.Pause:
			{
				Controller.SetState(State.PAUSE);
				break;
			}
		}
	}

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
				FindObjectOfType<SelectorInfoHandler>().HideContainers();
				break;
			}

			case ButtonID.InfoBuy:
			{
				if (EventManager.OnButtonClick != null)
				{
					EventManager.OnButtonClick(buttonID);
				}
				break;
			}


			case ButtonID.Play:
			{
				Controller.SetState(State.GAME);
				break;
			}
			case ButtonID.Restart:
			{
				if (EventManager.OnGameOver != null)
				{
					EventManager.OnGameOver();
				}
				break;
			}

			case ButtonID.ToggleVibration:
			{
				if (EventManager.OnButtonClick != null)
				{
					EventManager.OnButtonClick(buttonID);
				}
				break;
			}
			case ButtonID.ToggleSFX:
			{
				if (EventManager.OnButtonClick != null)
				{
					EventManager.OnButtonClick(buttonID);
				}
				break;
			}

			case ButtonID.Continue_Yes:
			{
				if(EventManager.OnSecondChanceDecision != null)
				{
					EventManager.OnSecondChanceDecision(true); 

					StatRecordController.CoinsCollected-= Controller.CONTINUE_COST; 
				}
				break; 
			}
			case ButtonID.Continue_No:
			{
				if(EventManager.OnSecondChanceDecision != null)
				{
					EventManager.OnSecondChanceDecision(false); 
				}
				break; 
			}
		}
	}
}
