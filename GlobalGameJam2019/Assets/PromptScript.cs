using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PromptScript : MonoBehaviour {

    float timer = 0.0f;
	// Use this for initialization
	void Start () {
        timer = 10.0f;
    }
	
    public void AddPrompt(string text, Texture texture)
    {
        gameObject.SetActive(true);
        timer = 10.0f;
        transform.Find("PromptText").GetComponent<Text>().text = text;
        if(texture)
        {
            transform.Find("PromptImage").GetComponent<RawImage>().texture = texture;
        }
        else
        {
            Destroy(transform.Find("PromptImage").GetComponent<RawImage>());
        }
        
    }

	// Update is called once per frame
	void Update () {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
            if (timer < 0.0f)
            {
                gameObject.SetActive(false);
            }
        }
	}
}
