using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelCompletedHandler : MonoBehaviour {

	private Text text; 
	private Animation animation; 
	private LevelController levelController;

	void Start () 
	{
		levelController = LevelController.Instance; 
		text = GetComponent<Text>(); 
		animation = GetComponent<Animation>(); 	
	}

	void OnEnable()
	{
		LevelController.OnLevelComplete+=OnLevelComplete; 
	}

	void OnDisable()
	{
		LevelController.OnLevelComplete-=OnLevelComplete; 		
	}

	void OnLevelComplete()
	{
		text.enabled = true; 
		text.text = "Level " + levelController.level.Index + " Completed"; 
		animation.Play(); 

		StartCoroutine("Delay"); 
	}

	IEnumerator Delay()
	{
		while(animation.isPlaying)
		{
			yield return null; 
		}

		text.enabled = false; 

		levelController.StartNewLevel(); 

		StopCoroutine("Delay"); 

	}
	
	void Update () {
		
	}
}
