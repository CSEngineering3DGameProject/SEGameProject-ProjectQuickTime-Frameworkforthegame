using UnityEngine;
using System;
using System.Collections;

public class CameraTestMovementScript : MonoBehaviour
{
    int zoom = 40;
    int normal = 32;
    float smooth = 5;

    private bool isZoomed = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            isZoomed = !isZoomed; //Checks if zoom is true or false, aka when right clicked.
        }

        if(isZoomed) //if statement for when right clicked.
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, zoom, Time.deltaTime * smooth); //Checks for right click and zooms in
        }

        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, normal, Time.deltaTime * smooth); //Will zoom out if anything else pops up
        }
    }
}
