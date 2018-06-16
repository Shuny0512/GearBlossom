using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3PlayerGenerator : MonoBehaviour {

	public GameObject Stage3Player;
	public GameObject Stage3PlayerObject1;
	public GameObject Stage3PlayerObject2;
	public int counter = 0;
	void Start () 
	{
		
		
	}
	

	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{ 
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			counter++;


			if (counter == 2) 
			{
				
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
				{
					Stage3PlayerObject1 = Instantiate (Stage3Player) as GameObject;
					Stage3PlayerObject1.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
					Stage3PlayerObject1.transform.rotation = Quaternion.Euler (0, 90, 0);
					Debug.Log (counter);

				}
			}

			if (counter == 3) 
			{
				
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
				{
					Stage3PlayerObject2 = Instantiate (Stage3Player) as GameObject;
					Stage3PlayerObject2.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
					Stage3PlayerObject2.transform.rotation = Quaternion.Euler (0, 180, 0);
					Debug.Log (counter);

				}
			}
		}
	}
}
