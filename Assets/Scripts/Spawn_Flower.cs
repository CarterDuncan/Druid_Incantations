using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Flower : MonoBehaviour {

    public int flower_count;

	// Use this for initialization
	void Start () {
        flower_count = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Button Pressed");
            SpawnFlower();
        }
	}

    void SpawnFlower()
    {
        Debug.Log("Flower Spawned");
    }
}
