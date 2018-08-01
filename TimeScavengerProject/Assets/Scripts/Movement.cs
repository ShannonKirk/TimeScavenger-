using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public float speed;
	

	// Use this for initialization
	void Start () {
		
		Debug.Log ("Script has started");
		
		
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.position += new Vector3 (speed, 0, 0);
		
	}
}
