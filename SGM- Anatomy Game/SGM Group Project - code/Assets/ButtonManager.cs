using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

	public Button resetButton;
	public Button volumeButton;
	public Spawner spawner;
	// Use this for initialization
	void Start () {
		resetButton.onClick.AddListener(resetGame);
		volumeButton.onClick.AddListener(toggleVolume);		
	}

	//delete organs
	//find outlines and enable
	// recreate organs

	public void resetGame()
	{
		GameObject[] tmp = GameObject.FindGameObjectsWithTag ("Organ");
		foreach (GameObject item in tmp) 
		{
			Destroy (item);	
		}
		GameObject[] tmp1 = GameObject.FindGameObjectsWithTag ("Outline");
		foreach (GameObject item in tmp1) 	
		{
			item.GetComponent<SpriteRenderer> ().enabled = true;
		}
		spawner.spawn();
	}
	public void toggleVolume()
	{
	}
}
