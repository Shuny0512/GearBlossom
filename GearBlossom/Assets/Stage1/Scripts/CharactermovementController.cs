using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactermovementController : MonoBehaviour 
{
	public float speed = 3.0f;
	public Button PlayButton;
	public static bool isStartGame;

	void Start () 
	{
		isStartGame = false;
	}
	

	void Update () 
	{
		if (isStartGame == true) 
		{
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}

	void Play ()
	{
		
	}
		

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.CompareTag ("TurntableLeft")) 
		{
			transform.position = new Vector3 (other.transform.position.x, 1, other.transform.position.z);
			transform.rotation = Quaternion.Euler (0, transform.rotation.eulerAngles.y - 90, 0);
			Debug.Log (transform.rotation.eulerAngles);
		}

		if (other.gameObject.CompareTag ("TurntableRight")) 
		{
			transform.position = new Vector3 (other.transform.position.x, 1, other.transform.position.z);
			transform.rotation = Quaternion.Euler (0, transform.rotation.eulerAngles.y + 90, 0);
		}

		if (other.gameObject.CompareTag ("SwitchPanel")) 
		{
			transform.position = new Vector3 (other.transform.position.x, 1, other.transform.position.z);
			Stage3Controller.OnorOff = false;
			Debug.Log (Stage3Controller.OnorOff);

		}
	}
}

