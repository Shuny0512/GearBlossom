using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayController : MonoBehaviour {

	public GameObject PreparationUI;
	public Button PlayButton;
	public GameObject PlayCharacter;
	public float speed = 3.0f;

	void Start () 
	{
		PreparationUI.SetActive (true);
		PlayButton.onClick.AddListener (StartUp);

	}
	

	void Update () 
	{
		
	}

	public void StartUp ()
	{
		PreparationUI.SetActive (false);
		PlayCharacter.transform.position += transform.forward * speed * Time.deltaTime;
		CharactermovementController.isStartGame = true;
	}
}
