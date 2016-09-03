using UnityEngine;
using System.Collections;

public class PaddlerScript : MonoBehaviour
{
	float paddleSpeed = 10f; //This could be dynamic as power up can change the scenario
	public GameObject ball;
	GameObject attachedBall;
	// Use this for initialization
	void Start ()
	{
		SpawnBall ();
	}
	void SpawnBall(){
		if (ball == null) {
			Debug.LogError ("Forgot Ball");
			return;
		}
		attachedBall = (GameObject)Instantiate (ball, transform.position + new Vector3 (0f, 0.45f, 0.0f), Quaternion.identity);
	}
	public void LooseLife(){
		SpawnBall ();
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
		if (attachedBall) {
			Rigidbody ballrigidbody = attachedBall.GetComponent<Rigidbody> ();
			ballrigidbody.position = transform.position + new Vector3 (0f, 0.45f, 0f);

			if (Input.GetButtonDown ("PlayGame")) {
				ballrigidbody.isKinematic = false;

				ballrigidbody.AddForce (300f * Input.GetAxis ("Horizontal"), 300f, 0);
				attachedBall = null;
			}
		}
	}
}

