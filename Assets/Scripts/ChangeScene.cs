using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene: MonoBehaviour {
    public GameObject Player;
    void Start()
    {
        Player = GameObject.Find("LeftHandAnchor");
    }

        void Update()
    {
        //if "A" pressed this frame
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            changeScene();
        }
    }

            public void changeScene()
    {
        SceneManager.LoadScene("MyScene");
    }

	
}
