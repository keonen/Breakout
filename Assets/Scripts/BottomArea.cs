using UnityEngine;
using System.Collections;

public class BottomArea : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.tag.Equals("Pelipallo"))
		{
			Debug.Log("Osui");
		}
	}
}
