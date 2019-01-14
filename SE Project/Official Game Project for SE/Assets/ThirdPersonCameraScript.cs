using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraScript : MonoBehaviour {

    public bool lockCursor;
    public float mouseSensitivity = 10;
    public Transform target;
    public float dstFromTarget = 2;
    public Vector2 pitchMinMax = new Vector2(-40, 85);

    public float rotationSmoothTime = .12f;
    Vector3 rotationSmoothVelocity;
    Vector3 currentRotation;

    float maxforx;
    float maxfory;

    void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void LateUpdate()
    {
        maxforx += Input.GetAxis("Mouse X") * mouseSensitivity;
        maxfory -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        maxfory = Mathf.Clamp(maxfory, pitchMinMax.x, pitchMinMax.y);

        currentRotation = Vector3.SmoothDamp(currentRotation, new Vector3(maxfory, maxforx), ref rotationSmoothVelocity, rotationSmoothTime);
        transform.eulerAngles = currentRotation;

        transform.position = target.position - transform.forward * dstFromTarget;

    }

}