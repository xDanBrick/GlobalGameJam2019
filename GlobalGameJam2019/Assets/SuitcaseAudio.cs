using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuitcaseAudio : MonoBehaviour {
    public AudioClip Suitcase;
    public AudioSource SuitcaseS;
	// Use this for initialization
	void Start () {
        SuitcaseS.PlayOneShot(Suitcase);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
