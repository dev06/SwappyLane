using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseUI : UserInterface {


	void OnEnable()
	{
		EventManager.OnStateChange += OnStateChange;
	}

	void OnDisable()
	{
		EventManager.OnStateChange -= OnStateChange;
	}


	public override void Init()
	{
		base.Init();
	}

	void OnStateChange(State s)
	{

		if (s != State.PAUSE)
		{
			Hide();
			return;
		}

		Show();
	}
}
