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

    private void OnTriggerStay(Collider2D collision)
    {
        Debug.Log("Trigger");
        if(collision.tag == "Caravan")
        {
            collision.transform.Find("Stuff Spawner").GetComponent<SpawnStuff>().stuffCount++;
        }
    }
}
