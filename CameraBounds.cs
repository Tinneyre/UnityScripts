using UnityEngine;
using System.Collections;

public class CameraBounds : MonoBehaviour
{

    private BoxCollider2D camBounds;
    private CameraBounds theCamBounds;
    private CameraController theCamera;

    // Use this for initialization
    void Start()
    {
        camBounds = GetComponent<BoxCollider2D>();
        theCamBounds = GetComponent<CameraBounds>();
        theCamera = FindObjectOfType<CameraController>();
        theCamera.SetBounds(camBounds);
        theCamera.SetCamBounds(theCamBounds);
    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
         
           camBounds = GetComponent<BoxCollider2D>();

            theCamera = FindObjectOfType<CameraController>();
            theCamera.SetBounds(camBounds);
            theCamera.SetCamBounds(theCamBounds);
        }
    }


}