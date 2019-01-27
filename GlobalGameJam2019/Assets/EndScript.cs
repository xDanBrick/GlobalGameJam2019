using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {

    [SerializeField] GameObject car;
    [SerializeField] GameObject plane;
    [SerializeField] GameObject newCaravanStuff;
    [SerializeField] GameObject oldCaravanStuff;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
        {
            
            plane.SetActive(true);
            newCaravanStuff.GetComponent<SpawnStuff>().counter = oldCaravanStuff.GetComponent<SpawnStuff>().counter;
            Destroy(car);
        }
    }
}
