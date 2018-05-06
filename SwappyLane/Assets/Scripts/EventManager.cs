using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

	public delegate void Hit(GameObject o);
	public static Hit OnObstacleHit;
	public static Hit OnCoinHit;


	public delegate void Gameplay();
	public static Gameplay OnGameOver;
	public static Gameplay OnSecondChance; 
	public static Gameplay OnCoinMiss; 

	public delegate void Bool(bool b); 
	public static Bool OnSecondChanceDecision; 


	public delegate void TerminalVelocityStatus(bool b);
	public static TerminalVelocityStatus OnTerminalVelocityStatus;

	public delegate void StateChange(State s);
	public static StateChange OnStateChange;

	public delegate void ButtonEvent(ButtonID buttonID);
	public static ButtonEvent OnButtonClick;


	public delegate void StoreItemClick(StoreItem storeItem, Package package);
	public static StoreItemClick OnStoreItemClick;
}
