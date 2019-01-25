using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralCity : MonoBehaviour {

    const float buildingGap = 0.3f;
    const float citySize = 50.0f;
    const float roadSize = 2.5f;
    [SerializeField] List<GameObject> buildings;

    // Use this for initialization
    void Start () {
        
        for (int i = 0; i < 2; ++i)
        {
            float x = 0.0f;
            int count = 0;
            bool isRoad = false;
            while (x < citySize)
            {
                if (Random.Range(0, 5) != 0 || isRoad)
                {
                    isRoad = false;
                    int num = Random.Range(0, buildings.Count);
                    Bounds bounds = buildings[num].GetComponent<Renderer>().bounds;
                    Instantiate(buildings[num], new Vector3((i * roadSize * 2.5f), 0.0f, x), buildings[num].transform.rotation);
                    x += bounds.size.z + buildingGap;
                }
                else
                {
                    isRoad = true;
                    if (i == 0)
                    {
                        float streetX = 0.0f;
                        for (int j = 0; j < 5; ++j)
                        {
                            int num = Random.Range(0, buildings.Count);
                            Bounds bounds = buildings[num].GetComponent<Renderer>().bounds;
                            streetX -= (bounds.size.x + buildingGap);
                            Instantiate(buildings[num], new Vector3(streetX, 0.0f, x + bounds.size.z), buildings[num].transform.rotation);
                            Instantiate(buildings[num], new Vector3(streetX, 0.0f, x - roadSize - buildingGap), buildings[num].transform.rotation);

                            //Instantiate(buildings[num], new Vector3(streetX, 0.0f, x + roadSize), buildings[num].transform.rotation);
                        }
                    }
                    
                    x += roadSize;
                }
                ++count;
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
