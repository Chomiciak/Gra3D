using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject pocisk = null;

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0)) {
			GameObject p = Instantiate (pocisk, transform.position, transform.rotation );
			p.transform.Rotate(new Vector3 (0,-90,0));
			//p.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3( 0, 0, 1000) );
			p.GetComponent<Rigidbody>().velocity = p.transform.forward * 60;
			/*
			Vector3 targetDir = transform.position - transform.position;
			float step = 1000 * Time.deltaTime;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
			Debug.DrawRay(transform.position, newDir, Color.red);
			transform.rotation = Quaternion.LookRotation(newDir);
			*/




			//p.GetComponent<Rigidbody> ().AddRelativeForce (new Vector3 (1000, 0, 0));
		}
	}
}
