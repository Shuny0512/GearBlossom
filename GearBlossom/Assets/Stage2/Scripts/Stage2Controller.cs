using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Controller : MonoBehaviour {

	public GameObject Stage2;
	public GameObject Bud;
	public GameObject Turntable;

	void Start () 
	{
		for (int x = 0; x <= 5; x++)
		{
			GameObject stage2 = Instantiate (Stage2) as GameObject;
			stage2.transform.position = new Vector3 (0, 0, x);
		}

		for (int y = 1; y <= 5; y++) 
		{
			GameObject stage2 = Instantiate (Stage2) as GameObject;
			stage2.transform.position = new Vector3 (-y, 0, 5);
		}

		GameObject bud = Instantiate (Bud) as GameObject;
		bud.transform.position = new Vector3 (-5, 1, 5);
		GameObject turntable = Instantiate (Turntable) as GameObject;
		turntable.transform.position = new Vector3 (0, 0.5f, 5);
		turntable.transform.rotation = Quaternion.Euler (0, 90, 0);




	}
	

	void Update () {
		
	}
}
