using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienShoot : MonoBehaviour {

    [SerializeField] GameObject bullet;
    [SerializeField] float shootInterval = 3.0f;
    float nextShootTime;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        if(Time.time > nextShootTime)
        {
            nextShootTime = Time.time + shootInterval;
            GameObject b = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            b.GetComponent<Rigidbody>().AddForce(new Vector3(0.0f, -1000.0f, 0.0f));

        }
	}
}
