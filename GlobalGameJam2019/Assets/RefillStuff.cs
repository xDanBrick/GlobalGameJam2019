using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RefillStuff : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider collider)
    {
        Debug.Log("Trigger");
        if(collider.tag == "Caravan")
        {
            collider.transform.Find("Stuff Spawner").GetComponent<SpawnStuff>().stuffCount++;
        }
    }
}
