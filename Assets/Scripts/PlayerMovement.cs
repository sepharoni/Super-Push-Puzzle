using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;

    public static Vector2 stick;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        stick = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetButton("Sprint"))
        {
            transform.Translate(stick.x * speed * Time.deltaTime * 1.5f, stick.y * speed * Time.deltaTime * 1.5f, 0);
        } 
        else
        {
            transform.Translate(stick.x * speed * Time.deltaTime, stick.y * speed * Time.deltaTime, 0);
        }
    }
}
