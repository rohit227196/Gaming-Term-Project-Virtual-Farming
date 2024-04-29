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
    public float deceleration = 3.0f;

    public float maxWalkSpeed = 1.0f;
    public float maxRunSpeed = 2.5f;

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
        bool jumpPressed = Input.GetKey(KeyCode.Space);
        //
        float maxVelocity = runPressed ? maxRunSpeed : maxWalkSpeed;

        if(forwardPressed && velocityZ < maxVelocity)
        {
            velocityZ += Time.deltaTime * acceleration;
        }
    
        if(backPressed && velocityZ > -maxVelocity)
        {
            velocityZ -= Time.deltaTime * acceleration;
        }
        
        if(leftPressed && velocityX > -maxVelocity)
        {
            velocityX -= Time.deltaTime * acceleration;
        }
        
        if (rightPressed && velocityX < maxVelocity)
        {
            velocityX += Time.deltaTime * acceleration;
        }
        //


        if(!forwardPressed && velocityZ > 0.0f)
                velocityZ -= Time.deltaTime * acceleration;
        else if (!backPressed && velocityZ < 0.0f)
                velocityZ += Time.deltaTime * acceleration;;
        if(!forwardPressed && !backPressed && velocityZ !=0 && (velocityZ > -0.05f && velocityZ < 0.05f))
                velocityZ = 0.0f;

        if (!leftPressed && velocityX < 0.0f)
            velocityX += Time.deltaTime * deceleration;
        else if(!rightPressed && velocityX > 0.0f)
            velocityX -= Time.deltaTime * deceleration;
        if (!leftPressed && !rightPressed && velocityX != 0.0f && (velocityX > -0.05f && velocityX < 0.05f))
            velocityX = 0.0f;

        if (runPressed && forwardPressed && velocityZ > maxVelocity)
            velocityZ = maxVelocity;
        else if (runPressed && backPressed && velocityZ < -maxVelocity)
            velocityZ = -maxVelocity;
        else if (forwardPressed && velocityZ > maxVelocity)
        { 
            velocityZ -= Time.deltaTime * deceleration;
            if (velocityZ > maxVelocity + 0.05f)
                velocityZ = maxVelocity;
        }
        else if (backPressed && velocityZ < -maxVelocity)
        { 
            velocityZ += Time.deltaTime * deceleration; 
            if (velocityZ < -maxVelocity - 0.05f)
                velocityZ = -maxVelocity;
        }
        else if (forwardPressed && velocityZ < maxVelocity && velocityZ > (maxVelocity - 0.05f))
            velocityZ = maxVelocity;
        else if (backPressed && velocityZ > -maxVelocity && velocityZ < (0.05f - maxVelocity))
            velocityZ = -maxVelocity;


        animator.SetFloat("Velocity Z", velocityZ);
        animator.SetFloat("Velocity X", velocityX);
    }
}
