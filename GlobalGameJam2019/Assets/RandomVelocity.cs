using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomVelocity : MonoBehaviour {

    Rigidbody rBody;

	// Use this for initialization
	void Start () {
        rBody = GetComponent<Rigidbody>();
        //rBody.velocity.Set(0.0f, 0.0f, 0.0f);
        Vector3 randomForce = new Vector3(Random.Range(500.0f, 1000.0f), Random.Range(500.0f, 1000.0f), Random.Range(500.0f, 1000.0f));
        //Vector3 randomForce = new Vector3(0.0f, 1000.0f, 0.0f);
        rBody.AddForce(randomForce);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
