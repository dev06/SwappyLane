using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectSFX : MonoBehaviour {

	private AudioSource source; 

	public AudioClip coin_collect; 
	public AudioClip block_hit; 

	private float pitch = 1f; 

	void OnEnable()
	{
		EventManager.OnCoinHit +=OnCoinHit; 
		EventManager.OnCoinMiss+=OnCoinMiss; 
		LevelController.OnLevelComplete+=OnLevelComplete; 
		EventManager.OnObstacleHit+=OnObstacleHit;

	}

	void OnDisable()
	{
		EventManager.OnCoinHit -=OnCoinHit; 
		EventManager.OnCoinMiss-=OnCoinMiss; 
		LevelController.OnLevelComplete-=OnLevelComplete; 
		EventManager.OnObstacleHit-=OnObstacleHit; 

	}


	void OnCoinHit(GameObject go)
	{	
		if(!Controller.SFX) return; 
		source.clip = coin_collect; 
		SetPitch(pitch + .05f); 
		source.Play(); 
	}

	void OnObstacleHit(GameObject go)
	{
		if(!Controller.SFX) return; 
		source.clip = block_hit; 
		SetPitch(1f); 
		source.Play(); 
	}

	void OnCoinMiss()
	{
		SetPitch(1f); 
	}

	void OnLevelComplete()
	{
		SetPitch(1f); 
	}


	void Start () 
	{
		source = GetComponent<AudioSource>(); 	
	}
	
	private void SetPitch(float pitch)
	{
		this.pitch = pitch; 
		source.pitch = pitch; 
	}
}
