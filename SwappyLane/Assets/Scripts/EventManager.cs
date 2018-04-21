using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void Hit(GameObject o);
	public static Hit OnObstacleHit; 
	public static Hit OnCoinHit; 


	public delegate void Gameplay();
	public static Gameplay OnGameOver; 


	public delegate void TerminalVelocityStatus(bool b); 
	public static TerminalVelocityStatus OnTerminalVelocityStatus; 
}
