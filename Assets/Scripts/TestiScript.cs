using UnityEngine;
using System.Collections;

public class TestiScript : MonoBehaviour {

	Vector3 direction;
	GameObject objekti;

	void Start ()
	{

	}
	
	public void Update()
	{
		objekti = GameObject.FindWithTag ("Cube");

		direction =  transform.position - objekti.transform.position;
		Physics.gravity = direction;

	}
}

