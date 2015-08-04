using UnityEngine;
using System.Collections;

public class HideStartMenu : MonoBehaviour {

	public GameObject parentObject;

	// Use this for initialization
	void Start () {
		parentObject=GameObject.Find("MainMenu");

		foreach(Renderer r in parentObject.GetComponentsInChildren<Renderer>())
			r.enabled=false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

