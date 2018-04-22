using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppResources : MonoBehaviour {


	public static GameObject Obstacle = (GameObject)Resources.Load("Prefabs/Obstacle") as GameObject;

	public static GameObject Coin = (GameObject)Resources.Load("Prefabs/Coin") as GameObject;

	public static GameObject StoreIconTemplate = (GameObject)Resources.Load("Prefabs/UI/StoreIconTemplate") as GameObject;


	public static GameObject char_1 = (GameObject)Resources.Load("Prefabs/Characters/char_1") as GameObject;
}
