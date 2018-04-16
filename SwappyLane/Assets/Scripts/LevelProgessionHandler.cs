using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class LevelProgessionHandler : MonoBehaviour {

	private LevelController levelController; 

	public RectTransform progressionBG;

	public RectTransform progressionFG; 

	public Text levelIndexText; 

	private float targetSizeX;  

	private float currentSizeX; 

	private float sizeLerpVel; 


	private Vector2 sizeVector;
	void Start () 
	{
		levelController = LevelController.Instance; 	

		sizeVector = new Vector2(0, progressionBG.sizeDelta.y); 
		
	}
	
	void Update () 
	{
		targetSizeX = (levelController.level.Progress / levelController.level.Length) * progressionBG.sizeDelta.x; 

		currentSizeX = Mathf.SmoothDamp(currentSizeX, targetSizeX, ref sizeLerpVel, Time.deltaTime * 1.3f); 

		sizeVector.x = currentSizeX; 

		progressionFG.sizeDelta = sizeVector;  

		levelIndexText.text = levelController.level.Index.ToString(); 
	}
}
