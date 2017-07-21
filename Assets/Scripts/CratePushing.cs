using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePushing : MonoBehaviour {
    public float speed;

    private bool isPushing;
    private GameObject player;

    private float moveHorizontal;
    private float moveVertical;

	// Use this for initialization
	void Start () {
        isPushing = false;
        player = GameObject.FindGameObjectWithTag("Player");
        moveHorizontal = 0.0f;
        moveVertical = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPushing)
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");

            if (PositionCheck() == "x")
            {
                transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, 0);
            } else if (PositionCheck() == "y")
            {
                transform.Translate(0, moveVertical * speed * Time.deltaTime, 0);
            }

        }	
	}

    string PositionCheck()
    {
        if (Mathf.Abs(player.transform.position.x - transform.position.x) > Mathf.Abs(player.transform.position.y - transform.position.y))
        {
            if (player.transform.position.x > transform.position.x && moveHorizontal < 0)
            {
                return "x";
            }

            if (player.transform.position.x < transform.position.x && moveHorizontal > 0)
            {
                return "x";
            }
        }

        if (Mathf.Abs(player.transform.position.y - transform.position.y) > Mathf.Abs(player.transform.position.x - transform.position.x))
        {
            if (player.transform.position.y > transform.position.y && moveVertical < 0)
            {
                return "y";
            }

            if (player.transform.position.y < transform.position.y && moveVertical > 0)
            {
                return "y";
            }
        }

        return "";
    }

    void OnCollisionEnter2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && !isPushing)
        {
            isPushing = true;
        }
    }

    void OnCollisionExit2D (Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && isPushing)
        {
            isPushing = false;
        }
    }
}
