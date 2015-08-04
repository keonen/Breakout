using UnityEngine;
using System.Collections;

public class InstantiatePaddle : MonoBehaviour {
	
	public GameObject pelilauta;
	
	// Use this for initialization
	void Start () {
		Instantiate(pelilauta, new Vector3(0, -6.5f ,0), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
