using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOrgan : MonoBehaviour {
	private float leftPoint;
	private float rightPoint;
	private float upPoint;
	private float downPoint;
	private float rotationMin = -0.1f;
	private float rotationMax = 0.1f;

	public GameObject OrganOutline;

	public bool locked;


	// Use this for initialization
	void Start () 
	{
		leftPoint = OrganOutline.transform.position.x - 0.1f;
		rightPoint = OrganOutline.transform.position.x + 0.1f;
		upPoint = OrganOutline.transform.position.y + 0.1f;
		downPoint = OrganOutline.transform.position.y - 0.1f;
	}
	
	// Update is called once per frame
	void Update () 
	{
			check ();
	}

	public void check()
	{
		if (gameObject.transform.position.x > leftPoint && gameObject.transform.position.x < rightPoint && gameObject.transform.position.y > downPoint && gameObject.transform.position.y < upPoint)
		{
			if (gameObject.transform.rotation.z > rotationMin && gameObject.transform.rotation.z < rotationMax) 
			{
				gameObject.transform.position = OrganOutline.transform.position;
				OrganOutline.GetComponent<SpriteRenderer> ().enabled = false;
				locked = true;
			}
		}
	}
}
