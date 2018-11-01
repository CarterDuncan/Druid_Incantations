using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCreation : MonoBehaviour {

    public Transform grass;
    public GameObject Behind_Player;
    CharacterController controller;
    public static int grass_counter;
    public int dist_travelled;


    // Use this for initialization and for coroutine 
    IEnumerator Start()
    {
        Behind_Player = GameObject.Find("Avatar Trail");
        controller = GetComponent<CharacterController>();
        grass_counter = 0;

        yield return StartCoroutine(WaitAndCreate(200.0F));
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 horizontalVelocity = controller.velocity;
        horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);

        // The speed on the x-z plane ignoring any speed
        float horizontalSpeed = horizontalVelocity.magnitude;
      
        
        if (horizontalSpeed > 0 && grass_counter < 100)
        {
            dist_travelled = 0;
            Instantiate(grass, Behind_Player.transform.position, Behind_Player.transform.rotation);
            grass_counter++;
            WaitAndCreate(200.0F);
        }
	}

    //suspend execution of create grass for waitTime seconds 
    IEnumerator WaitAndCreate(float waitTime)
    {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndCreate " + Time.time);
    }





    /*private IEnumerator coroutine;

    void Start()
    {
        // - After 0 seconds, prints "Starting 0.0"
        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        coroutine = WaitAndPrint(2.0f);
        StartCoroutine(coroutine);

        print("Before WaitAndPrint Finishes " + Time.time);
    }

    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        }
    }*/
}
