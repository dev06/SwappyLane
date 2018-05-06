using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class SettingButton : ButtonEventHandler {


	private SettingsHandler settingHandler;
	private Vector3 targetRotation;



	void OnEnable()
	{
		EventManager.OnStateChange+=OnStateChange; 
	}
	void OnDisable()
	{
		EventManager.OnStateChange-=OnStateChange; 
	}


	void Start()
	{
		settingHandler = FindObjectOfType<SettingsHandler>();
	}

	void Update()
	{
		transform.localRotation = Quaternion.Lerp(transform.localRotation, Quaternion.Euler(targetRotation), Time.deltaTime * 10f);
	}


	void OnStateChange(State s)
	{
		if(s != State.MENU)
		{
			targetRotation = new Vector3(0, 0, 0f);
			transform.localRotation = Quaternion.Euler(targetRotation); 
			return; 
		}
	}


	public override void OnPointerClick(PointerEventData data)
	{
		base.OnPointerClick(data);

		if (EventManager.OnButtonClick != null)
		{
			EventManager.OnButtonClick(buttonID);
		}


		targetRotation = new Vector3(0, 0, settingHandler.Active ? -45f : 0f);

	}
}
