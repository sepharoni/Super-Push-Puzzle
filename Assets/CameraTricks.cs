using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTricks : MonoBehaviour {

    public Vector3 cameraRotateTowards;
    public float cameraZoomSpeed;

    private Camera cam;

    private Quaternion defaultCameraRotation;
    private Vector3 defaultCameraPosition;
    private float defaultCameraOrthographicSize; //should be 5, but grab it anyways to avoid magic numbers

    private GameObject player;

    public int randomTrick;
    private int totalNumberOfTricks = 2;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        defaultCameraRotation = transform.rotation;
        defaultCameraPosition = transform.position;
        defaultCameraOrthographicSize = cam.orthographicSize;
        player = GameObject.FindGameObjectWithTag("Player");
        if (randomTrick == 0)
        {
            randomTrick = Random.Range(1, totalNumberOfTricks + 1);
        }
    }

    public void PickTrick()
    {
        if (randomTrick == 1)
        {
            FlushEffect(1);
        } 
        else if (randomTrick == 2)
        {
            FlushEffect(-1);
        }
    }

    public void FlushEffect(int modifier)
    {
        transform.Rotate(cameraRotateTowards * modifier * Time.deltaTime);
        transform.parent = player.transform;
        cam.orthographicSize -= Time.deltaTime * cameraZoomSpeed * modifier;
    }

    public void ResetCamera() //instantly reset all camera properties to default
    {
        transform.rotation = defaultCameraRotation;
        transform.position = defaultCameraPosition;
        cam.orthographicSize = defaultCameraOrthographicSize;
        transform.parent = null;
    }
}
