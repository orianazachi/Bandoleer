using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
     [SerializeField] private Camera cam;
    [SerializeField] private Transform planetToOrbit;
    
    private UnityEngine.Vector3 previousMousePosition;

    [SerializeField] private float rotationSpeed = 1.0f;
    [SerializeField] private float zoomSpeed = 1.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            previousMousePosition = Input.mousePosition;
        }

        if (Input.GetMouseButton(1))
        {
           UnityEngine.Vector3 mouseDelta = Input.mousePosition - previousMousePosition;

            // Rotate the camera based on mouse movement
            float rotationX = -mouseDelta.y * rotationSpeed;
            float rotationY = mouseDelta.x * rotationSpeed;
            transform.RotateAround(planetToOrbit.position, UnityEngine.Vector3.up, rotationY);
            transform.RotateAround(planetToOrbit.position, transform.right, rotationX);

            // Zoom in/out based on mouse wheel input
            float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
            transform.Translate(UnityEngine.Vector3.forward * scrollDelta * zoomSpeed);

            previousMousePosition = Input.mousePosition;
        }
    }

    
}
