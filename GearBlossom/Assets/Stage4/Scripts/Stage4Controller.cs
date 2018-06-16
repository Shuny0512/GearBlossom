using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Controller : MonoBehaviour 
{

	public GameObject Stage4Prefab;
	public GameObject TurntablerightPrefab;
	public GameObject TurntableleftPrefab;


	void Start () 
	{
		
		for (int x = 0; x <= 7; x++) 
		{
			GameObject stage4objectxa = Instantiate (Stage4Prefab) as GameObject;
			stage4objectxa.transform.position = new Vector3 (x, 0, 0);

			GameObject stage4objectxb = Instantiate (Stage4Prefab) as GameObject;
			stage4objectxb.transform.position = new Vector3 (x, 0, 7);
		}

		GameObject stageobjectxc = Instantiate (Stage4Prefab) as GameObject;
		stageobjectxc.transform.position = new Vector3 (8, 0, 0);

		for (int z = 0; z <= 7; z++) 
		{
			GameObject stage4objeza = Instantiate (Stage4Prefab) as GameObject;
			stage4objeza.transform.position = new Vector3 (3, 0, z);

			GameObject stage4objectzb = Instantiate (Stage4Prefab) as GameObject;
			stage4objectzb.transform.position = new Vector3 (5, 0, z);
		}


		GameObject stg4turntablerighta = Instantiate (TurntablerightPrefab) as GameObject;
		stg4turntablerighta.transform.position = new Vector3 (5, 0.5f, 0);
		stg4turntablerighta.transform.rotation= Quaternion.Euler (0, 180, 0);

		GameObject stg4turntablerightb = Instantiate (TurntablerightPrefab) as GameObject;
		stg4turntablerightb.transform.position = new Vector3 (5, 0.5f, 7);
		stg4turntablerightb.transform.rotation = Quaternion.Euler (0, -90, 0);



		GameObject stg4turntablelefta = Instantiate (TurntableleftPrefab) as GameObject;
		stg4turntablelefta.transform.position = new Vector3 (3, 0.5f, 0);
		stg4turntablelefta.transform.rotation = Quaternion.Euler (0, 180, 0);

		GameObject stgturnttableleftb = Instantiate (TurntableleftPrefab) as GameObject;
		stgturnttableleftb.transform.position = new Vector3 (3, 0.5f, 7);
		stgturnttableleftb.transform.rotation = Quaternion.Euler (0, 90, 0);




		
	}
	

	void Update () {
		
	}
}
