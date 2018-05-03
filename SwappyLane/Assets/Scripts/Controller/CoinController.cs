using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour {

	public static CoinController Instance; 

	public int levelCoins; 

	private CoinHUD coinHUD; 

	void Awake()
	{
		if(Instance == null)
		{
			Instance = this; 
		}
		else
		{
			Destroy(Instance); 
		}
	}

	void OnEnable()
	{
		EventManager.OnCoinHit+=OnCoinHit; 
	}

	void OnDisable()
	{
		
		EventManager.OnCoinHit-=OnCoinHit; 
	}

	void OnCoinHit(GameObject g)
	{
		g.SetActive(false); 
		LevelCoins++; 
		coinHUD.UpdateHUD(); 
		Haptic.Vibrate(HapticIntensity.Light); 
	}
	
	void Start () 
	{
		coinHUD = FindObjectOfType<CoinHUD>(); 
	}
// Update is called once per frame
	void Update () {

	}

	public int LevelCoins
	{
		get{return levelCoins; }
		set{this.levelCoins = value; }
	}
}
