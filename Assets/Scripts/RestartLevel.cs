using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

    private float countdownToRestart;

	// Use this for initialization
	void Start () {
        countdownToRestart = 0.75f;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Restart"))
        {
            countdownToRestart -= Time.deltaTime;
            if (countdownToRestart <= 0.0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            countdownToRestart = 0.75f;
        }

    }
}
