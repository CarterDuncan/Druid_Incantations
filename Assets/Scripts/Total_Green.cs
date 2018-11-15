using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total_Green : MonoBehaviour
{
    public static bool fog;

    public GameObject player;
    public GameObject player_hands;

    public int total_counter;

    void Start()
    {
        total_counter = 0;
        RenderSettings.fog = true;
        RenderSettings.fogDensity = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        updateTheFog();
    }

    public void updateTheFog()
    {
        total_counter = player.GetComponent<GrassCreation>().grass_counter + player_hands.GetComponent<Spawn_Flower>().flower_count;
        if (total_counter > 20 && total_counter < 40)
            RenderSettings.fogDensity = 0.04f;
        else if (total_counter > 40 && total_counter < 60)
            RenderSettings.fogDensity = 0.03f;
        else if (total_counter > 60 && total_counter < 80)
            RenderSettings.fogDensity = 0.02f;
        else if (total_counter > 80 && total_counter < 1000)
            RenderSettings.fogDensity = 0.01f;
        else if (total_counter > 100)
            RenderSettings.fog = false;
        //Debug.Log(RenderSettings.fogDensity);
    }
}