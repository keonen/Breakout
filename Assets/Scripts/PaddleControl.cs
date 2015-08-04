using UnityEngine;
using System.Collections;

public class PaddleControl : MonoBehaviour {

	public float horizontal;
	public float speed = 10f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		horizontal = Input.GetAxis ("Horizontal");

		transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
//		transform.position += new Vector3(horizontal, 0f, 0f);



		if (transform.position.x > 9.5 )
		{
			transform.position = new Vector3(9.5f, -6.5f, 0f);
		}

		if (transform.position.x < -9.5 )
		{
			transform.position = new Vector3(-9.5f, -6.5f, 0f);
		}

	}
}
