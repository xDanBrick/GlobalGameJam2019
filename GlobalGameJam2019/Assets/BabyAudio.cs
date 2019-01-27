using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyAudio : MonoBehaviour {

    [FMODUnity.EventRef]
    public string BabyEvent = "event:/Stuff/Baby";
    FMOD.Studio.EventInstance Baby;

	// Use this for initialization
	void Start () {
        Baby.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Baby.start();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
