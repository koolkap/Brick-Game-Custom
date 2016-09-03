using UnityEngine;
using System.Collections;

public class OuterRegionField : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter(Collider other){
		BallScript ball = other.GetComponent<BallScript>();

		if (ball) {
			ball.Die ();
		}
	}
}

