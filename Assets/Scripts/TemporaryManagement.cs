using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryManagement : MonoBehaviour {
    private int score;
    private int maxScore;

    private GameObject[] gos;

    private float countdownToWin;

    private GameObject cam;
    private Camera handycam;

    public float winningCameraRotation;
    private float defaultCameraRotation;

    // Use this for initialization
    void Start () {
        score = 0;
        gos = GameObject.FindGameObjectsWithTag("Sokoban");
        maxScore = gos.Length;
        countdownToWin = 3.0f;
        cam = GameObject.Find("Main Camera");
        handycam = cam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update () {
        if (score >= maxScore)
        {
            countdownToWin -= Time.deltaTime;
            if (countdownToWin < 0.75f)
            {
                cam.transform.Rotate(0, 0, winningCameraRotation * Time.deltaTime);
                cam.transform.parent = transform;
                handycam.orthographicSize -= Time.deltaTime * 2.25f;
            }
            if (countdownToWin <= 0.0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        else if (countdownToWin != 3.0f)
        {
            countdownToWin = 3.0f;
            cam.transform.rotation = new Quaternion(0, 0, 0, 0);
            cam.transform.parent = null;
            handycam.orthographicSize = 5;
        }		
	}

    public void UpdateScore(int amount)
    {
        score += amount;
    }
}
