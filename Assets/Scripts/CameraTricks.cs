using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTricks : MonoBehaviour {

    public Vector3 cameraRotateTowards;
    public float cameraZoomSpeed;
    public float cameraShakeIntensity;

    private Camera cam;

    private Quaternion defaultCameraRotation;
    private Vector3 defaultCameraPosition;
    private float defaultCameraOrthographicSize; //should be 5, but grab it anyways to avoid magic numbers

    private GameObject player;
    private Renderer playerRenderer;

    public int randomTrick;
    private int totalNumberOfTricks = 4;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
        defaultCameraRotation = transform.rotation;
        defaultCameraPosition = transform.position;
        defaultCameraOrthographicSize = cam.orthographicSize;
        player = GameObject.FindGameObjectWithTag("Player");
        playerRenderer = player.GetComponent<Renderer>();
        if (randomTrick == 0)
        {
            randomTrick = Random.Range(1, totalNumberOfTricks + 1);
        }
    }

    public void PickTrick(int trickID)
    {
        switch(trickID)
        {
            case 1:
                FlushEffect(1);
                break;
            case 2:
                FlushEffect(-1);
                break;
            case 3:
                ShakeEffect(1);
                break;
            case 4:
                ShakeEffect(-1);
                break;
            default:
                Debug.Log("PickTrick() switch-case fell through. trickID: " + trickID);
                break;
        }
    }

    void FlushEffect(int modifier)
    {
        transform.Rotate(cameraRotateTowards * modifier * Time.deltaTime);
        //transform.parent = player.transform;
        Zoom(modifier);
    }

    void ShakeEffect(int modifier)
    {
        transform.Translate(Random.Range(-cameraShakeIntensity, cameraShakeIntensity) *Time.deltaTime, Random.Range(-cameraShakeIntensity, cameraShakeIntensity) *Time.deltaTime, 0.0f);
        Zoom(modifier);

    }

    void Zoom(int modifier)
    {
        cam.orthographicSize -= Time.deltaTime * cameraZoomSpeed * modifier;
        if (!playerRenderer.isVisible)
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
        }
    }

    public void FinalShot()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, Time.deltaTime * 10.0f);
    }

    public void ResetCamera() //instantly reset all camera properties to default
    {
        transform.rotation = defaultCameraRotation;
        transform.position = defaultCameraPosition;
        cam.orthographicSize = defaultCameraOrthographicSize;
        transform.parent = null;
    }
}
