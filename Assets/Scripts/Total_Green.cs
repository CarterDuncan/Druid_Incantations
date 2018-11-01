using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Total_Green : MonoBehaviour {
    static int total_green;
    public GameObject sunflower;
    public TerrainData terrainData;
    //public Component GetComponent(Type type);

	// Use this for initialization
	void Start () {
        total_green = 0;
        Debug.Log("I work");
	}
	
	// Update is called once per frame
	void Update () {
        if (Instantiate(sunflower))
            total_green++;
        //ChangeTerrainColor(terrainData);
    }
    /*public void ChangeTerrainColor(TerrainData terrainData) {
    Renderer rend = Terrain.getComponenet<Renderer>();
     if (total_green > 0 && total_green < 25)
         rend.material.color = new Vector4(0, .1f, .5f, .7f);
     if (total_green > 25 && total_green < 50)
          rend.material.color = new Vector4(0, .1f, .5f, .7f);
      if (total_green > 50 && total_green < 75)
          rend.material.color = new Vector4(0, .1f, .5f, .7f);
    }*/
}


//create a list that will add an object to the list every timem its instantiteated
//counter == size of list 
//https://answers.unity.com/questions/996317/how-add-values-to-genericlist.html
//https://answers.unity.com/questions/318607/how-to-access-the-size-of-a-list-c.html


