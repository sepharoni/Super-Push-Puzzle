using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TemporaryManagement : MonoBehaviour {
    private int score;
    private int maxScore;

    private GameObject[] gos;

    public float countdownToWin;
    private float defaultCountdownToWin;

    private CameraTricks camTricks;

    // Use this for initialization
    void Start () {
        score = 0;
        gos = GameObject.FindGameObjectsWithTag("Sokoban");
        maxScore = gos.Length;
        defaultCountdownToWin = countdownToWin;
        camTricks = Object.FindObjectOfType<CameraTricks>();
    }

    // Update is called once per frame
    void Update () {
        if (score >= maxScore)
        {
            countdownToWin -= Time.deltaTime;
            if (countdownToWin < defaultCountdownToWin/2.0f)
            {
                camTricks.PickTrick(camTricks.randomTrick);
            }
            if (countdownToWin < defaultCountdownToWin/10.0f)
            {
                camTricks.FinalShot();
            }
            if (countdownToWin <= 0.0f)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }

        else if (countdownToWin != defaultCountdownToWin)
        {
            countdownToWin = defaultCountdownToWin;
            camTricks.ResetCamera();
        }		
	}

    public void UpdateScore(int amount)
    {
        score += amount;
    }
}
