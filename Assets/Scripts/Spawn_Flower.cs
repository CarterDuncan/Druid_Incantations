using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Flower : MonoBehaviour
{

    public int flower_count;
    public Transform sunflower;
    Rigidbody plant;

    public float flowerPosY = 0.0f;

    //number of elements to be initiated 
    public int NumElements = 1;
    //the transform object to be initiated
    public Transform prefab;

    //the controllable player
    public GameObject Player;
    //how far away from player
    private float DistFromPlayer = 10.0f;
    //how many elements have been created
    private int generatedElementsCount = 0;

    public int updateCounter;

    public float timeSinceInst = 0;

    // Use this for initialization
    void Start()
    {
        Player = GameObject.Find("LeftHandAnchor");
        flower_count = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timeSinceInst += Time.deltaTime;
        //if "A" pressed this frame
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("Button Pressed");
                if (flower_count < 50)
                {

                    CreateElements();
                    
                }
                if (flower_count >= 50)
                {
                    Debug.Log("Flower Quota Reached");
                    return;
                }
        }
    }

    void CreateElements()
    {
        //if object been instantiated in last .4 seconds 
        //Debug.Log(timeSinceInst);
        if (timeSinceInst < 1.0f)
        {
            return;
        }
        timeSinceInst = 0f;
        Player = GameObject.Find("LeftHandAnchor");

        //create the object as a transform
        Transform elem;

        Transform PlayerPosition = Player.transform;
        PlayerPosition.position = new Vector3(Player.transform.position.x, flowerPosY, Player.transform.position.z);
        
        elem = Instantiate(prefab, PlayerPosition.position, prefab.rotation) as Transform;
        Debug.Log("Made Flower");

        //update the position and rotation of the object
        elem.transform.Translate(new Vector3(DistFromPlayer, 7, 0));

        flower_count++;
        //Debug.Log("added to count ");
        return;
    }
}