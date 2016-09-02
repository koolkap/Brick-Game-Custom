using UnityEngine;
using System.Collections;

public class PaddlerScript : MonoBehaviour
{
	float paddleSpeed = 10f; //This could be dynamic as power up can change the scenario

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (paddleSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"), 0, 0); //Move only in the x direction
		//Debug.Log(transform.position.x);
		if (transform.position.x > 3.0f) {
			transform.position = new Vector3(3.0f, transform.position.y, transform.position.z);
		}
		if (transform.position.x < -3.0f) {
			transform.position = new Vector3(-3.0f, transform.position.y, transform.position.z);
		}
		if(Input.GetButtonDown("PlayGame")){
			//TODO: lauch the ball make the surface non-sticky as per power.
		}
	}
}

