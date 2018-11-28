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
        //if "Y" pressed this frame
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            changeScene();
        }
        //if "X" pressed this frame
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            changeScene2();
        }
    }

    public void changeScene()
    {
        SceneManager.LoadScene("MyScene");
    }
    public void changeScene2()
    {
        SceneManager.LoadScene("UI");
    }


}
