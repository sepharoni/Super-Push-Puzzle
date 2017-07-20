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
        }

        else if (moveHorizontal < 0)
        {
            anim.SetInteger("State", 4);
        }

        else if (moveVertical > 0)
        {
            anim.SetInteger("State", 3);
        }

        else if (moveVertical < 0)
        {
            anim.SetInteger("State", 2);
        }

        if (moveVertical == 0 && moveHorizontal == 0)
        {
            anim.SetInteger("State", 0);
        }
		
	}
}
