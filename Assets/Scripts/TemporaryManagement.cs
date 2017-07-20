using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryManagement : MonoBehaviour {
    public int score;
    private int maxScore;

    private GameObject[] gos;

    private float countdownToWin;
    private float countdownToRestart;

    // Use this for initialization
    void Start () {
        score = 0;
        gos = GameObject.FindGameObjectsWithTag("Sokoban");
        maxScore = gos.Length;
        countdownToWin = 3.0f;
        countdownToRestart = 0.75f;
    }

    // Update is called once per frame
    void Update () {
        if (score >= maxScore)
        {
            countdownToWin -= Time.deltaTime;

            if (countdownToWin <= 0.0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        else
        {
            countdownToWin = 3.0f;
        }

        if (Input.GetButton("Fire1"))
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
