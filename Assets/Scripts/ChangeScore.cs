using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScore : MonoBehaviour {

    private bool isTriggered;

    private GameObject go;
    private TemporaryManagement tempManage;

    private float roundPosiitonTimer;


	// Use this for initialization
	void Start () {
        isTriggered = false;
        go = GameObject.Find("Temporary Management");
        tempManage = go.GetComponent<TemporaryManagement>();
        roundPosiitonTimer = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isTriggered)
        {
            roundPosiitonTimer += Time.deltaTime;
            if (roundPosiitonTimer >= 1.5f)
            {
                roundPosiitonTimer = 0.0f;
                transform.position = new Vector3(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y), 0);
            }
        }
		
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Sokoban")
        {
            if (!isTriggered)
            {
                isTriggered = true;
                tempManage.score += 1;
            }
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.tag == "Sokoban")
        {
            if (isTriggered)
            {
                isTriggered = false;
                tempManage.score -= 1;                
            }
        }
    }
}
