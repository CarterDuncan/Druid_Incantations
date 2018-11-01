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
        Player = GameObject.Find("Player");
        flower_count = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
        //if "A" pressed this frame
		if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Button Pressed");
            //Instantiate
            //SpawnFlower();
            //SpawnPlant
            CreateElements();
        }
        //if A released this frame
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {
            Debug.Log("Button released");
            flower_count++;
        }
	}
    //creats a volly of flowers at origin!?! Need to fix position
    void SpawnFlower()
    {
        Debug.Log("Flower Spawned");
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
        }
    }
    //haven't tessted but idea to create and launch flower to floor like projectile, will need to tweak velocity so lands perfectly
    void SpawnPlant()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(plant, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
    void CreateElements()
    {
        Debug.Log("Entered Function");
        for (int i = 0; i < NumElements; i++)
        {
            Debug.Log("Entered Loop");
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
            elem = Instantiate(sunflower, Player.transform.position, Player.transform.rotation) as Transform;

            elem.name = objectName;

            //update the position and rotation of the object
            elem.transform.Rotate(new Vector3(0, currentRotation, 0));
            elem.transform.Translate(new Vector3(DistFromPlayer, 5, 0));
        }
    }

}
