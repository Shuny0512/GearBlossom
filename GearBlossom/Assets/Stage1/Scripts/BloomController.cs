using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BloomController : MonoBehaviour 
{
	public GameObject Flower;


	void Start () 
	{
		
	}
	

	void Update () {
		
	}

	void OnTriggerEnter (Collider hit)
	{
		if ( hit.gameObject.CompareTag("Player")) 
		{ 
			Destroy (this.gameObject);
			GameObject flower = Instantiate (Flower) as GameObject;
			flower.transform.position = new Vector3 (0,0,0);

		}
	}
			
}
