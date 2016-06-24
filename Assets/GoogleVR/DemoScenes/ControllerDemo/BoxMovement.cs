using UnityEngine;
using System.Collections;
using System;

public class BoxMovement : MonoBehaviour {

	private Vector3 cubePosition;
	private float count;
	private int randomNum;
	private const float MOVE_SPEED = 0.1f;


	// Use this for initialization
	void Start () {
		randomNum = UnityEngine.Random.Range (0, 2);
		count = 0;
		cubePosition = new Vector3 ();
	}
	
	// Update is called once per frame
	void Update () {
		if (randomNum == 0) {
			cubePosition = transform.position + new Vector3 (MOVE_SPEED * (float)Math.Cos ((2 * Math.PI * count) / 60), 0, 0);
		}
		if (randomNum == 1) {
			cubePosition = transform.position + new Vector3 (0, MOVE_SPEED * (float)Math.Cos ((2 * Math.PI * count) / 60), 0);
		}
		transform.position = cubePosition;
		count += 0.4f;
		}
	

}
