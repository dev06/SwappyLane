using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	private Vector3[] positions;
	private Vector3 chosenLocation; 


	public Link link; 
	void Start () {
		positions = new Vector3[4];
		positions[0] = new Vector3(-1f, 0f, 0f);
		positions[1] = new Vector3(0, 1f, 0f);
		positions[2] = new Vector3(1f, 0f, 0f);
		positions[3] = new Vector3(0, -1f, 0f);
		//transform.localPosition = new Vector3(0, 1, transform.localPosition.z); 
	}

	public Link Link
	{
		get{
			return link; 
		}
		set{
			this.link = value; 
		}
	}
}
