using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionAudio : MonoBehaviour {

    [FMODUnity.EventRef]
    public string ExplosionHitEvent = "event:/UFO/ExplosionHit";
    FMOD.Studio.EventInstance ExplosionHit;

	// Use this for initialization
	void Start () {
        ExplosionHit.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        ExplosionHit.start();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
