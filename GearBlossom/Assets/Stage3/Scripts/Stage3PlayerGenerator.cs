using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3PlayerGenerator : MonoBehaviour {

	public GameObject Stage3Player;
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

			if (counter == 1) 
			{
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
				{
					GameObject firststage3Player = Instantiate (Stage3Player) as GameObject;
					firststage3Player.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
					firststage3Player.transform.rotation = Quaternion.Euler (0, 90, 0);
					Debug.Log (counter);
				}
			}

			if (counter == 2) 
			{
				if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
				{
					GameObject secondstage3Player = Instantiate (Stage3Player) as GameObject;
					secondstage3Player.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
					secondstage3Player.transform.rotation = Quaternion.Euler (0, 180, 0);
				}
			}
		}
	}
}
