using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMaster : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        if (moveHorizontal > 0)
        {
            anim.SetInteger("State", 1);
            anim.speed = Mathf.Abs(moveHorizontal);
        }

        else if (moveHorizontal < 0)
        {
            anim.SetInteger("State", 4);
            anim.speed = Mathf.Abs(moveHorizontal);
        }

        else if (moveVertical > 0)
        {
            anim.SetInteger("State", 3);
            anim.speed = Mathf.Abs(moveVertical);
        }

        else if (moveVertical < 0)
        {
            anim.SetInteger("State", 2);
            anim.speed = Mathf.Abs(moveVertical);
        }

        if (moveVertical == 0 && moveHorizontal == 0)
        {
            anim.SetInteger("State", 0);
            anim.speed = 1.0f;
        }

        if (Input.GetButton("Sprint"))
        {
            anim.speed = anim.speed * 1.5f;
        }
		
	}
}
