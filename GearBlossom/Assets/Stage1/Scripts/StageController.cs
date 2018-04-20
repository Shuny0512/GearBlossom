using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour {

	public GameObject Stage;
	public GameObject Bud;



	void Start () 
	{
		for (int x = 1; x <= 6; x++) 
			{
				GameObject stage = Instantiate (Stage) as GameObject;
				stage.transform.position = new Vector3 (0, 0, x);
			}

		GameObject bud = Instantiate (Bud) as GameObject;
		bud.transform.position = new Vector3 (0, 1, 6);

	}


	void Update () {
		
	}
}
