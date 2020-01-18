using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject Canvas;

    public float gravity;
    public float sideSpeed;
    public float forwardSpeed;
    public float tiltSpeed;
    public float sideTiltSpeed;
    public float speed = 0f;
    public float sideRotation = 0f;
    public float upRotation = 0f;
    public float sideTilt;
    public bool escape = false;

    void FixedUpdate ()
    {
        upRotation = 0f;
        sideRotation = 0f;
        sideTilt = 0f;
        Physics.gravity = new Vector3(0, -gravity, 0);

        if (Input.GetKey(KeyCode.W))
        {
            upRotation += tiltSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            upRotation -= tiltSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            sideTilt -= sideTiltSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            sideTilt += sideTiltSpeed;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            speed += forwardSpeed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            speed -= forwardSpeed;
        }
        if (Input.GetKey(KeyCode.Y))
        {
            sideRotation -= sideSpeed;
        }
        if (Input.GetKey(KeyCode.X))
        {
            sideRotation += sideSpeed;
        }

        transform.Rotate(new Vector3(upRotation, sideTilt, sideRotation));
        transform.Translate(-Vector3.up * speed * Time.deltaTime);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!escape)
            {
                Time.timeScale = 0;
                Canvas.SetActive(!escape);
            }
            else
            {
                Time.timeScale = 1;
                Canvas.SetActive(!escape);
            }
            escape = !escape;
        }
    }

    public void escapeQuit()
    {
        Application.Quit();
    }
}
