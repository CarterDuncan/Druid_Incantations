using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Flower : MonoBehaviour {

    public int flower_count;
    public GameObject sunflower;


	// Use this for initialization
	void Start () {
        flower_count = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        //if "A" pressed this frame
		if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Button Pressed");
            //Instantiate
            SpawnFlower();
        }
        //if A released this frame
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            Debug.Log("Button released");
     
        }
	}

    void SpawnFlower()
    {
        Debug.Log("Flower Spawned");
    }

}
