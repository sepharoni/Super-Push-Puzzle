using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CratePushing : MonoBehaviour
{
    public float speed;

    private bool isPushing = false;
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (isPushing && isMoving())
        {
            if (PositionCheck())
                transform.Translate(PlayerMovement.stick.x * speed * Time.deltaTime, 0, 0);
            else
                transform.Translate(0, PlayerMovement.stick.y * speed * Time.deltaTime, 0);
        }
    }

    bool PositionCheck()
    {
        if (Mathf.Abs(player.transform.position.x - transform.position.x) > Mathf.Abs(player.transform.position.y - transform.position.y))
            return true;
        else
            return false;
    }

    bool isMoving()
    {
        if (PlayerMovement.stick != Vector2.zero)
            return true;
        else
            return false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && !isPushing)
        {
            isPushing = true;
        }
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && isPushing)
        {
            isPushing = false;
        }
    }
}