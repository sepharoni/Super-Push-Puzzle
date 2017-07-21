using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour {

    private float countdownToQuit;

	// Use this for initialization
	void Start () {
        countdownToQuit = 0.33f;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Quit"))
        {
            countdownToQuit -= Time.deltaTime;
            if (countdownToQuit <= 0.0f)
            {
                Application.Quit();
            }
        }

        else
        {
            countdownToQuit = 0.33f;
        }
		
	}
}
