using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGenerator : MonoBehaviour 
{

	public GameObject StagePlayer;

	void Start () 
	{
		
	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) {


				GameObject stageplayer = Instantiate (StagePlayer) as GameObject;
				stageplayer.transform.position = new Vector3 (hit.transform.position.x, 1, hit.transform.position.z);
			}
		}
	}
}
