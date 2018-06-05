using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Controller : MonoBehaviour {

	public GameObject StagePrefab;
	public GameObject TurntableRightPrefab;
	public GameObject TurntableLeftPrefab;
	public GameObject Switchpanel;
	public static bool OnorOff;
	public GameObject TurntableRightObject;
	public GameObject TurntableLeftObject;

	void Start () 
	{
		OnorOff = true;
		TurntableRightPrefab.SetActive (true);
		TurntableLeftPrefab.SetActive (false);
		GameObject turntablerightbox = Instantiate (TurntableRightObject) as GameObject;
		GameObject turntableleftbox = Instantiate (TurntableLeftObject) as GameObject;

		for (int z = -2; z <= 5; z++) 
		{
			GameObject stagelane1 = Instantiate (StagePrefab) as GameObject;
			stagelane1.transform.position = new Vector3 (-4, 0, z);
		}

		for (int x = 0; x <= 6; x++) 
		{
			GameObject stagelane2 = Instantiate (StagePrefab) as GameObject;
			stagelane2.transform.position = new Vector3 (-x, 0, 0);
		}

		GameObject switchpanel = Instantiate (Switchpanel)  as GameObject;
		switchpanel.transform.position = new Vector3 (-4, 0.5f, -2);

		GameObject turntableright = Instantiate (TurntableRightPrefab) as GameObject;
		turntableright.transform.position = new Vector3 (-4, 0.5f, 0);


		GameObject turntableleft = Instantiate (TurntableLeftPrefab) as GameObject;
		turntableleft.transform.position = new Vector3 (-4, 0.5f, 0);




	}
	

	void Update () 
	{

		if (OnorOff == true) 
		{

			TurntableRightObject.SetActive (true);
			TurntableLeftObject.SetActive (false);
		}	

		if (OnorOff == false) 
		{
			
			TurntableRightObject.SetActive (false);
			TurntableLeftObject.SetActive (true);

		}
			
	}

	void SwitchUp ()
	{
	}
}
