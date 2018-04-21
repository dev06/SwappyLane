using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuUI : UserInterface {

	public Text currentLevelText;

	private LevelController levelController;

	public override void Init()
	{
		base.Init();


		levelController = LevelController.Instance;
		currentLevelText.text = "Level " + levelController.level.Index;
	}

	void Update ()
	{
		if (Controller.GameState == State.MENU)
		{

			if (Input.GetMouseButtonDown(0))
			{
				Controller.SetState(State.GAME);
				Debug.LogError("Called");
				Hide();
			}
		}
	}

	public override void Show()
	{
		group.alpha = 1;
		group.blocksRaycasts = true;
	}

	public override void Hide()
	{
		group.alpha = 0f;
		group.blocksRaycasts = false;
	}

}
