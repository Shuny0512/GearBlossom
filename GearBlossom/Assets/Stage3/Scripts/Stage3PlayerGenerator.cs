using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3PlayerGenerator : MonoBehaviour 
{

	public GameObject Stage3Player;
	public GameObject Stage3PlayerObject1;
	public GameObject Stage3PlayerObject2;
	public int counter = 1;
	void Start () 
	{
		
		
	}
	


	void Update ()

	{

		if (Input.GetMouseButtonDown (0)) 
	
		{ 
			
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			Debug.Log (counter); 

		
			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
			{
				if (hit.collider.CompareTag ("Player"))
				{
					this.gameObject.transform.Rotate (new Vector3 (0, 90, 0));
				}

				if (counter <= 2) 
				{
					Stage3PlayerObject1 = Instantiate (Stage3Player) as GameObject;
					Stage3PlayerObject1.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
					counter++;
					Debug.Log (counter);

				}
			}
		}
	}
}
