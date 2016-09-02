using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	//Destroy the ball prefab
	//In the score reduce the life by one
	void Die(){
		Destroy (gameObject);
	}	
}
