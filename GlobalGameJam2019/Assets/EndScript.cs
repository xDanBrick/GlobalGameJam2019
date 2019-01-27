using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;

public class EndScript : MonoBehaviour {

    [SerializeField] GameObject car;
    [SerializeField] GameObject plane;
    [SerializeField] GameObject newCaravanStuff;
    [SerializeField] GameObject oldCaravanStuff;
    [SerializeField] GameObject cam;

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
            cam.GetComponent<AutoCam>().m_Target = plane.transform.GetChild(2);
            Destroy(car);
            Destroy(GameObject.Find("MinimapCamera"));
        }
    }
}
