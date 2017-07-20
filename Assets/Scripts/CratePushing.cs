using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePushing : MonoBehaviour {
    public float speed;

    private bool isPushing;
    private GameObject player;

	// Use this for initialization
	void Start () {
        isPushing = false;
        player = GameObject.FindGameObjectWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isPushing)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            if (player.transform.position.x > transform.position.x && moveHorizontal < 0 && (Mathf.Abs(player.transform.position.x - transform.position.x) > Mathf.Abs(player.transform.position.y - transform.position.y)))
            {
                transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, 0);
            }
            else if (player.transform.position.x < transform.position.x && moveHorizontal > 0 && (Mathf.Abs(player.transform.position.x - transform.position.x) > Mathf.Abs(player.transform.position.y - transform.position.y)))
            {
                transform.Translate(moveHorizontal * speed * Time.deltaTime, 0, 0);
            }

            if (player.transform.position.y > transform.position.y && moveVertical < 0 && (Mathf.Abs(player.transform.position.y - transform.position.y) > Mathf.Abs(player.transform.position.x - transform.position.x)))
            {
                transform.Translate(0, moveVertical * speed * Time.deltaTime, 0);
            }
            else if (player.transform.position.y <  transform.position.y && moveVertical > 0 && (Mathf.Abs(player.transform.position.y - transform.position.y) > Mathf.Abs(player.transform.position.x - transform.position.x)))
            {
                transform.Translate(0, moveVertical * speed * Time.deltaTime, 0);
            }


        }
		
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
