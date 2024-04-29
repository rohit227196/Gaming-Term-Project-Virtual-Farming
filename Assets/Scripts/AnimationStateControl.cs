using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AnimationStateControl : MonoBehaviour
{
    Animator animator;
    private float velocityX = 0.0f;
    private float velocityZ = 0.0f;

    public float acceleration = 2.0f;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
        bool leftPressed = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
        bool rightPressed = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
        bool backPressed = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        if(forwardPressed)
        {
            velocityZ += Time.deltaTime * acceleration;

        }

        if(leftPressed)
        {
            velocityX -= Time.deltaTime * acceleration;
        }

        if(rightPressed)
        {
            velocityX += Time.deltaTime * acceleration;
        }
    }
}
