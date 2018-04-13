using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public GameObject obstacle;

	private Vector3[] positions;

	void Start () {
		positions = new Vector3[4];
		positions[0] = new Vector3(-.25f, 0f, 0f);
		positions[1] = new Vector3(0, .25f, 0f);
		positions[2] = new Vector3(.25f, 0f, 0f);
		positions[3] = new Vector3(0, -.25f, 0f);

		SpawnObstacle();
	}

	void Update () {

	}


	public void SpawnObstacle()
	{
		for (int i = 0; i < 4; i++)
		{
			GameObject clone = (GameObject)Instantiate(obstacle, positions[Random.Range(0, 4)] + new Vector3(0f, 0f, 8 + i), Quaternion.identity) as GameObject;
			clone.transform.SetParent(FindObjectOfType<Platform>().transform);
			clone.transform.localScale = new Vector3(1, 1, clone.transform.localScale.z);

		}
	}
}
