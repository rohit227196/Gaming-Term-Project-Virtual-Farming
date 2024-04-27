using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static bool rotateWithMouse = true;
    public float rotationSpeed = 5f;
    public float verticalRotationSpeed = 3f;
    public float movementSpeed = 5f;
    private Rigidbody rb;

    public static bool isCursorLocked = true;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleCursorLock();
        }

        if (!isCursorLocked)
        {
            return;
        }
        RotateWithMouse();

        transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0f);

        MoveWithKeys();
    }

    public static void ToggleCursorLock()
    {
        isCursorLocked = !isCursorLocked;

        if (isCursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    void RotateWithMouse()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

  
        rb.MoveRotation(rb.rotation * Quaternion.Euler(Vector3.up * mouseX * rotationSpeed));


        Vector3 currentRotation = rb.rotation.eulerAngles;
        currentRotation.x -= mouseY * verticalRotationSpeed;

 
        if (currentRotation.x > 180f)
        {
            currentRotation.x -= 360f;
        }
        else if (currentRotation.x < -180f)
        {
            currentRotation.x += 360f;
        }


        currentRotation.x = Mathf.Clamp(currentRotation.x, -80f, 80f);


        rb.MoveRotation(Quaternion.Euler(currentRotation));

    }

    void MoveWithKeys()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical) * movementSpeed * Time.deltaTime;


        rb.MovePosition(rb.position + transform.TransformDirection(movement));
    }
}