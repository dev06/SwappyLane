using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class SecondChanceUI : UserInterface {

	public Text titleText; 
	public Text remaingCoins; 

	private Animation animation; 

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

		animation = GetComponent<Animation>(); 
	}	

	void OnStateChange(State s)
	{
		if(s != State.SECOND_CHANCE)
		{
			Hide(); 
			return; 
		}

		Show(); 
	}	

	public override void Show()
	{
		base.Show(); 

		titleText.text = Controller.CONTINUE_COST + " x" ;  

		remaingCoins.text = "x " + StatRecordController.CoinsCollected; 

		animation.Play(); 
	}
}
