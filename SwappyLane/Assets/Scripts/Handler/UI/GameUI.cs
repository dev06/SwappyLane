using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : UserInterface {


	public override void Init()
	{
		base.Init();
	}

	void OnEnable()
	{
		EventManager.OnStateChange += OnStateChange;
	}
	void OnDisable()
	{
		EventManager.OnStateChange -= OnStateChange;
	}

	void OnStateChange(State s)
	{
		if (s != State.GAME) return;

		Show();
	}

	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{

	}
}
