using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public delegate void LevelComplete(); 
	public static LevelComplete OnLevelComplete; 


	public static LevelController Instance; 

	void Awake()
	{
		if(Instance == null)
		{
			Instance = this; 
		}
	}

	public Level level;

	public void Initalize()
	{
		if(level == null)
		{
			level = new Level(1); 
		}
	}

	void Start () {

	}
	
	void Update () {
		
	}

	public void IncrementLevel()
	{
		if(level == null)
		{
			level = new Level(1); 			
		}
		else
		{
			level = new Level(level.Index + 1); 
		}
	}

	public void UpdateLevelProgress()
	{
		if(level == null)
		{
			level = new Level(1); 
			return; 
		}

		level.Progress++; 
		//Debug.Log(level.ToString()); 

		if(level.Progress >= level.Length)
		{
			if(OnLevelComplete != null)
			{
				OnLevelComplete(); 
			}
			IncrementLevel(); 
//			Debug.Log("Next-> " + level.ToString()); 
		}
	}

}

public class Level
{
	private int index; 
	private float length; 
	private float progress;

	private float maxVelocity; 


	public Level(int index)
	{
		this.index = index;
		Length = index * 10; 
		maxVelocity = (index) + 8; 
		maxVelocity = Mathf.Clamp(maxVelocity, LinkController.MIN_VELOCITY, LinkController.MAX_VELOCITY); 
	}

	public float MaxLevelVelocity
	{
		get{return maxVelocity;} 
	}

	public int Index{
		get{return index; }
		set{this.index = value; }
	}

	public float Length{
		get{return length; }
		set{this.length = value; }
	}

	public float Progress{
		get{return progress; }
		set{this.progress = value; }
	}

	public string ToString()
	{
		return "Index: " + index + " | "  + progress + "/" + length; 
	}


}
