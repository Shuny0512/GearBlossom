using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2GimicGenerator : MonoBehaviour {

	public GameObject Turntable;
	public GameObject Stage2Player;
	public int counter = 0;
	void Start () 
	{
		
	}
	

	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			if (counter == 0)
			{
				Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				RaycastHit hit;
				counter++;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity)) 
			{
				Debug.Log (hit.collider.gameObject.name);
				GameObject player = Instantiate (Stage2Player) as GameObject;
				player.transform.position = new Vector3 (hit.transform.position.x, hit.transform.position.y + 1, hit.transform.position.z);
			
			}
		}
	}
}
}
