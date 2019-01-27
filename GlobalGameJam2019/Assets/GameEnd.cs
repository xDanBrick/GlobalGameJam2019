using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour {

    public static int counter = 100;
    [SerializeField] GameObject endCamera;
    [SerializeField] GameObject ufo;
    [SerializeField] GameObject prompt;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider collider)
    {
        if(collider.tag == "Player")
        {
            //-350 // 
            Destroy(GameObject.Find("MultipurposeCameraRig"));
            endCamera.SetActive(true);
            ufo.SetActive(true);
            prompt.GetComponent<PromptScript>().AddPrompt("Your score is " + counter.ToString(), null);
        }
    }
}
