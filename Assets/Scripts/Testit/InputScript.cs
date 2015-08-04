using UnityEngine;
using System.Collections;

public class InputScript : MonoBehaviour {

	public float horizontalValue = 10;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			Debug.Log("Key A pressed!");
		}

		horizontalValue = Input.GetAxis ("Horizontal");

//		GameObject.FindWithTag("Pelilauta").transform.

	}
}
