using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAngularVelocity : MonoBehaviour {

    [SerializeField] Rigidbody rBody;
    [SerializeField] GameObject stuffSpawner;

    float nextSpawnTime = 0.0f;
    float interval = 0.25f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Debug.Log(rBody.angularVelocity.y);

        if(Mathf.Abs(rBody.angularVelocity.y) > 2 && Time.time > nextSpawnTime)
        {
            interval = (0.25f / Mathf.Abs(rBody.angularVelocity.y));
            nextSpawnTime = Time.time + interval;
            stuffSpawner.GetComponent<SpawnStuff>().Spawn();
        }
	}
}
