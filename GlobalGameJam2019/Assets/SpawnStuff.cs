using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStuff : MonoBehaviour {

    [SerializeField] GameObject[] stuff;
    int counter = 100;
	// Use this for initialization
	void Start () {
		
	}

	
	public int stuffCount
    {
        get { return counter; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                counter = value;
                GameObject.Find("TshirtFill").GetComponent<Image>().fillAmount = counter * 0.01f;
            }
        }
    }
    
    // Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        int thing = (int)Random.Range(0.0f, stuff.Length);

        Instantiate(stuff[thing], transform.position, Random.rotation);
        if(counter > 0)
        {
            --counter;
            GameObject.Find("TshirtFill").GetComponent<Image>().fillAmount = counter * 0.01f;
        }
    }
}
