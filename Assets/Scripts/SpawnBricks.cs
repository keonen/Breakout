using UnityEngine;
using System.Collections;

public class SpawnBricks : MonoBehaviour {

	public GameObject brick_1;
	public GameObject brick_2;

	// Use this for initialization
	void Start () 
	{
		for (int b = 0; b < 6; b++) {
			for (int a = -5; a < 6; a++) {
				//Instantiate(brick, new Vector3((float)2 * a, (float)2 * b, 0f), Quaternion.identity);

				if (b % 2 == 0)
				{
					if (a % 2 == 0)
					{
						Instantiate(brick_1, new Vector3(2 * a, b ,0), transform.rotation);
					}
					else
					{
						Instantiate(brick_2, new Vector3(2 * a, b ,0), transform.rotation);
					}
				}
				else
				{

					if (a % 2 == 0)
					{
						Instantiate(brick_2, new Vector3(2 * a, b ,0), transform.rotation);
					}
					else
					{
						Instantiate(brick_1, new Vector3(2 * a, b ,0), transform.rotation);
					}
				}
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
