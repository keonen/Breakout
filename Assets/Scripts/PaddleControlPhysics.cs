using UnityEngine;
using System.Collections;

public class PaddleControlPhysics : MonoBehaviour {

	public float horizontal;
	public float speed;

	private Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
			horizontal = Input.GetAxis ("Horizontal");

			//rigidbody.velocity = Vector2.right * horizontal * speed;

			//rigidbody.AddForce(startForce, ForceMode2D.Impulse);
			

	}
}
