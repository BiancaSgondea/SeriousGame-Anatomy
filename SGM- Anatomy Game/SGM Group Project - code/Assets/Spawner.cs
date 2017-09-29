using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject heart;
	public GameObject brain;
	public GameObject spleen;
	public GameObject kidneys;
	public GameObject liver;
	public GameObject stomach;
	public GameObject intestines;
	public GameObject lungs;
	public GameObject pancreas;
	// Use this for initialization
	void Start () {
		spawn ();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void spawn ()
	{
		Instantiate (heart, gameObject.transform);
		Instantiate (brain, gameObject.transform);
		Instantiate (spleen, gameObject.transform);
		Instantiate (kidneys, gameObject.transform);
		Instantiate (liver, gameObject.transform);
		Instantiate (stomach, gameObject.transform);
		Instantiate (intestines, gameObject.transform);
		Instantiate (lungs, gameObject.transform);
		Instantiate (pancreas, gameObject.transform);
	
	
	}
}
