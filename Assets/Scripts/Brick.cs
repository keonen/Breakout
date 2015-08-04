using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D collision)
	{
		Destroy (gameObject, 0.01f);
	}
	
	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
