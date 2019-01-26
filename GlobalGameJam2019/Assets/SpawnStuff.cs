using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour {

    [SerializeField] GameObject[] stuff;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        int thing = (int)Random.Range(0.0f, stuff.Length);

        Instantiate(stuff[thing], transform.position, Random.rotation);
    }
}
