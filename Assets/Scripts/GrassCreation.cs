using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassCreation : MonoBehaviour
{

    public Transform grass;
    public GameObject Behind_Player;
    CharacterController controller;
    public int grass_counter;
    public int debug_counter;
    public int dist_travelled;
    public int updateCounter;
    public float fps;


    // Use this for initialization and for coroutine 
    IEnumerator Start()
    {
        Behind_Player = GameObject.Find("Avatar Trail");
        controller = GetComponent<CharacterController>();
        grass_counter = 0;

        yield return StartCoroutine(WaitAndCreate(200.0F));
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        updateCounter++;
        Vector3 horizontalVelocity = controller.velocity;
        horizontalVelocity = new Vector3(controller.velocity.x, 0, controller.velocity.z);

        fps = 1 * Time.deltaTime;
        Debug.Log(fps);

        // The speed on the x-z plane ignoring any speed
        float horizontalSpeed = horizontalVelocity.magnitude;
        if (updateCounter % fps == 1)
            if (horizontalSpeed > 0 && grass_counter < 100)
            {
                dist_travelled = 0;
                Instantiate(grass, Behind_Player.transform.position, Behind_Player.transform.rotation);
                grass_counter++;
                WaitAndCreate(200.0F);
            }
        if (grass_counter == 100 && debug_counter == 0)
        {
            Debug.Log("Grass Quota Reached");
            debug_counter++;
        }
    }

    //suspend execution of create grass for waitTime seconds 
    IEnumerator WaitAndCreate(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndCreate " + Time.time);
    }
}
