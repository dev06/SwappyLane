using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class CoinHUD : MonoBehaviour {


	public Text coinTextDisplay; 

	private CoinController coinController; 


	void Start () 
	{
		coinController = CoinController.Instance; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void UpdateHUD()
	{
		coinTextDisplay.text = coinController.LevelCoins.ToString(); 
	}

}
