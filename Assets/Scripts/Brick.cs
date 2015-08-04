using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

	Animator animator;

	void OnCollisionEnter2D(Collision2D collision)
	{
		animator.SetTrigger("ChangeState");
		GetComponent<BoxCollider2D>().enabled = false;
		Destroy (gameObject, 1f);
	}
	
	// Use this for initialization
	void Start () 
	{
		animator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
