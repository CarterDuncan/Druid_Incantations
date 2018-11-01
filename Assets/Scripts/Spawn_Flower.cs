using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Flower : MonoBehaviour {

    public int flower_count;
    public Transform sunflower;
    Rigidbody plant;

    //number of elements to be initiated 
    public int NumElements = 5;
    //the transform object to be initiated
    public Transform prefab;

    //the controllable player
    public GameObject Player;
    //how far away from player
    private float DistFromPlayer = 10.0f;
    //how many elements have been created
    private int generatedElementsCount = 0;

    // Use this for initialization
    void Start () {
        Player = GameObject.Find("LeftHandAnchor");
        flower_count = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        //if "A" pressed this frame
		if (OVRInput.GetDown(OVRInput.Button.One))
        {
            //Debug.Log("Button Pressed");
            //SpawnFlower();
            if(flower_count < 50)
            {
                CreateElements();
            }
            if(flower_count >=50)
            {
                Debug.Log("Flower Quota Reached");
            }
           
        }
	}
    //creats a volly of flowers at origin!?! Need to fix position
    void SpawnFlower()
    {
        //Debug.Log("Flower Spawned");
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }    
    void CreateElements()
    {
        Player = GameObject.Find("LeftHandAnchor");
        for (int i = 0; i < NumElements; i++)
        {
            //update total elements created
            generatedElementsCount++;
            //name of the instatntiated object
            string objectName = "Element_" + generatedElementsCount;
            //angle of instantiated object
            float angleIteration = 360 / NumElements;
            //rotation of instantiation object
            float currentRotation = angleIteration * i;

            //create the object as a transform
            Transform elem;

            elem = Instantiate(prefab, Player.transform.position, Player.transform.rotation) as Transform;

            elem.name = objectName;

            //update the position and rotation of the object
            elem.transform.Rotate(new Vector3(0, currentRotation, 0));
            elem.transform.Translate(new Vector3(DistFromPlayer, 0, 0));

            flower_count++;
            //Make adjustments, so not so many and maybe tinker position/spacing
        }
    }

}
