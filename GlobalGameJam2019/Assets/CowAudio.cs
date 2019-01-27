using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowAudio : MonoBehaviour {

    [FMODUnity.EventRef]
    public string CowEvent = "event:/Stuff/Cow";
    FMOD.Studio.EventInstance Cow;

	// Use this for initialization
	void Start () {
		Cow.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Cow.start();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
