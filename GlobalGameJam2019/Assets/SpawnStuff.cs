using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnStuff : MonoBehaviour {

    [SerializeField] GameObject prompt;
    [SerializeField] Texture texture;
    [SerializeField] GameObject[] stuff;
	// Use this for initialization
	void Start () {
        GameEnd.counter = 100;

    }

	
	public int stuffCount
    {
        get { return GameEnd.counter; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                GameEnd.counter = value;
                GameObject.Find("TshirtFill").GetComponent<Image>().fillAmount = GameEnd.counter * 0.01f;
            }
        }
    }
    
    // Update is called once per frame
	void Update () {
		
	}

    public void Spawn()
    {
        if (GameEnd.counter > 0)
        {
            int thing = (int)Random.Range(0.0f, stuff.Length);
            Instantiate(stuff[thing], transform.position, Random.rotation);

            --GameEnd.counter;
            GameObject.Find("TshirtFill").GetComponent<Image>().fillAmount = GameEnd.counter * 0.01f;
            if (GameEnd.counter == 0)
            {
                prompt.GetComponent<PromptScript>().AddPrompt("Fill up your belongings at the nearest Home Bargins", texture);
            }
        }
    }
}
