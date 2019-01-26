using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterSeconds : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(DeleteGameObject());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator DeleteGameObject()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(gameObject);
    }
}
