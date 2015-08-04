using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PalloLiike : MonoBehaviour {
		

		private Rigidbody2D rigidbody;
		public int bounces = 0;
		public float bounceAcceleration = 1.1f; 
		public Vector2 startDirection = Vector2.down;
		public Vector2 gravityForce = Vector2.down;
		public float startSpeed;
		public float currentSpeed;
		public float constantVelocity = 10;
		public Vector2 startVelocity;
		public Vector2 currentVelocity;
		public bool unhandledCollision = false;

		public float distanceFromPaddle = 0.1f;
		public bool startSituation = true;
		public GameObject paddle;
		public GameObject ball;
		public GameObject gameover;
		public GameObject youwon;
		public Vector3 previousPosition;
		
		public float maxSpeed = 10;
		public int scorePoints = 0;

		public Text scoreText;

	// Use this for initialization
	void Awake () 
	{
		Screen.SetResolution (900, 600, false);
		rigidbody = GetComponent<Rigidbody2D> ();

	}

	void Start () 
	{

		paddle = GameObject.FindWithTag("Pelilauta");
		ball = GameObject.FindWithTag("Pelipallo");

		paddle.transform.position = new Vector3(0f, -6.5f, 0f);
		
		Vector3 startPosition = paddle.transform.position;
		ball.transform.position = startPosition;
		
	}

	void Update()
	{
		
		if (startSituation && Input.GetKeyDown(KeyCode.Space) && scorePoints == 0)
		{
			// rigidbody.AddForce(startForce, ForceMode2D.Impulse);
			// rigidbody.velocity = startVelocity;
			startSituation = false;
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(Application.loadedLevel);
		}


		if (transform.position.y < -8 )
		{
			Instantiate(gameover, new Vector3(0 ,0 ,0), Quaternion.identity);
			startSituation = true;
		}

		if (GameObject.FindWithTag("Tiili") == null && !startSituation) 
		{
			Instantiate(youwon, new Vector3(0 ,0 ,0), Quaternion.identity);
			startSituation = true;			
		}
	}

	void LateUpdate()
	{

		if(startSituation)
		{
			paddle = GameObject.FindWithTag("Pelilauta");
			ball = GameObject.FindWithTag("Pelipallo");

//			currentVelocity = ball.transform.position - previousPosition;
//			startDirection = Vector2.up;
//			previousPosition = paddle.transform.position;

			ball.transform.position = paddle.transform.position;
			if (scorePoints == 0)
			{
				Vector3 temp = new Vector3(0, 0.77f, 0);
				ball.transform.position += temp;
			}
			else
			{
				Vector3 temp = new Vector3(0, 0f, 0);
				ball.transform.position += temp;
			}
		}

		if ( rigidbody.velocity.magnitude > maxSpeed )
		{
			rigidbody.velocity = rigidbody.velocity.normalized * maxSpeed;
		}
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
//		startVelocity = rigidbody.velocity;
//		rigidbody.AddForce (gravityForce, ForceMode2D.Force);
//
//		if(!startSituation)
//		{
//			currentSpeed = rigidbody.velocity.magnitude;
//		}

		rigidbody.velocity = constantVelocity * (rigidbody.velocity.normalized);

	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log ("Hit " + bounces + " " + collision.collider.gameObject.name);

		bounces++;

		if ( rigidbody.velocity.magnitude < maxSpeed )
		{
			//float nextSpeed = constantVelocity * Mathf.Pow (bounceAcceleration, bounces);
			//rigidbody.velocity = rigidbody.velocity.normalized * nextSpeed;
			//constantVelocity = constantVelocity * 2;


		}

		if(collision.collider.tag == "Tiili")
		{
			scorePoints++;
			Debug.Log (scorePoints);
			scoreText.text = "Score: " + scorePoints;
		}

	}
}
