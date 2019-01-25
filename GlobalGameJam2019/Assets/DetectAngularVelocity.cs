using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAngularVelocity : MonoBehaviour {

    [SerializeField] Rigidbody rBody;
    [SerializeField] GameObject stuffSpawner;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(rBody.angularVelocity.y);

        if(Mathf.Abs(rBody.angularVelocity.y) > 2)
        {
            stuffSpawner.GetComponent<SpawnStuff>().Spawn();
        }
	}
}
