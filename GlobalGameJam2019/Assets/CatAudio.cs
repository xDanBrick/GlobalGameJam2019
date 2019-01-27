using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatAudio : MonoBehaviour {

    [FMODUnity.EventRef]
    public string CatEvent = "event:/Stuff/Cat";
    FMOD.Studio.EventInstance Cat;

	// Use this for initialization
	void Start () {
		Cat.set3DAttributes(FMODUnity.RuntimeUtils.To3DAttributes(gameObject));
        Cat.start();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
