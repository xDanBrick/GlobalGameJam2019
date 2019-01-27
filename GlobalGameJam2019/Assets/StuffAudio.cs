using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffAudio : MonoBehaviour {

    [FMODUnity.EventRef]
    public string WhooshEvent = "event:/Stuff/Whoosh";
    FMOD.Studio.EventInstance Whoosh;

	// Use this for initialization
	void Start () {
		Whoosh.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Whoosh.start();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
