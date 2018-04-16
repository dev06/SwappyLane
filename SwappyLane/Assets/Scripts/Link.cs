using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link : MonoBehaviour {

	private Controller controller; 

	private  List<Vector3> positions; 

	public List<GameObject> obstacles; 

	private List<Vector3> availablePosition; 

	private Vector3 chosenLocation; 

	private Link prevLink; 

	private bool canTranslate; 

	private float timer = 0; 
	
	private Quaternion targetRotation; 

	private LinkController linkController; 

	private LevelController levelController; 


	
	void Start () 
	{

		controller = Controller.Instance; 
		linkController = LinkController.Instance; 
		levelController = LevelController.Instance; 
		obstacles = new List<GameObject>(); 

		positions = new List<Vector3>();
		positions.Add(new Vector3(-1, 0f, 0f));
		positions.Add(new Vector3(0, 1, 0f));
		positions.Add(new Vector3(1, 0f, 0f));
		positions.Add(new Vector3(0, -1, 0f));

		availablePosition = positions; 

		chosenLocation = transform.localPosition; 

		GameObject prefab = AppResources.Obstacle; 
		
		
		for(int i = 0;i < 4; i++)
		{
			GameObject clone = (GameObject)Instantiate(prefab) as GameObject;
			clone.transform.SetParent(transform); 
			Vector3 location = availablePosition[Random.Range(0,availablePosition.Count)]; 
			clone.transform.localPosition = location; 
			availablePosition.Remove(location); 
			clone.transform.localScale = new Vector3(1,1,clone.transform.localScale.z); 
			obstacles.Add(clone); 
			clone.SetActive(false); 
		}

		ActiveCubes(); 

		transform.gameObject.SetActive(false); 

		targetRotation = transform.localRotation; 
	}

	private void ActiveCubes()
	{
		for(int i = 0;i < obstacles.Count; i++)
		{
			obstacles[i].SetActive(false); 
		}
		
		int count =	Random.Range(1, (levelController.level.Index / 2) + 1); 

		count = Mathf.Clamp(count, 1, 3); 

		for(int i = 0;i < count; i++)
		{
			obstacles[i].SetActive(true); 
		}

	}


	void Update () {
		CheckIfOutside(); 

		timer+=Time.deltaTime; 

		if(timer > 1.0f)
		{
			int prob = Random.Range(0,2) == 0 ? -1 : 1; 
			targetRotation *= Quaternion.Euler(new Vector3(0,0,prob * 90)); 			
			timer = 0; 
		}

		//transform.localRotation = Quaternion.Lerp(transform.localRotation, targetRotation, Time.deltaTime *20f); 

		if(CanTranslate)
		{
			transform.Translate(Vector3.forward * -1f *  Time.deltaTime * linkController.Velocity);									
		}

		transform.localPosition = new Vector3(chosenLocation.x,chosenLocation.y, transform.localPosition.z); 
	}

	void CheckIfOutside()
	{

		if (transform.localPosition.z < -.5f)
		{
			transform.localPosition = new Vector3(0,0, .5f); 
			CanTranslate = false; 
			ChangeCubeSides(); 
			levelController.UpdateLevelProgress(); 
			transform.gameObject.SetActive(false); 
		}
	}


	private void ChangeCubeSides()
	{
		positions.Clear(); 

		positions.Add(new Vector3(-1, 0f, 0f));
		positions.Add(new Vector3(0, 1, 0f));
		positions.Add(new Vector3(1, 0f, 0f));
		positions.Add(new Vector3(0, -1, 0f));

		availablePosition = positions; 

		for(int i = 0;i < obstacles.Count; i++)
		{
			Vector3 location = availablePosition[Random.Range(0,availablePosition.Count)];
			obstacles[i].transform.localPosition = location; 
			availablePosition.Remove(location); 
		}

		ActiveCubes(); 
	}

	public Link PrevLink
	{
		get{
			return prevLink; 
		}

		set{
			prevLink = value; 
		}
	}

	public bool CanTranslate
	{
		get{
			return canTranslate; 
		}
		set {
			this.canTranslate = value; 
		}
	}
}
