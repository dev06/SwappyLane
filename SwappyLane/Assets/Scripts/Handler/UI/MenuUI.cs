using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUI : UserInterface {

	public Text currentLevelText;

	private LevelController levelController;
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


		levelController = LevelController.Instance;
		currentLevelText.text = "Level " + levelController.level.Index;
	}

	void OnStateChange(State s)
	{

		if (s != State.MENU)
		{
			Hide();
			return;
		}

		Show();
	}
}
