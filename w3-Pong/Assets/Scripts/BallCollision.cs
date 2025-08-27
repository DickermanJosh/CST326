using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UIElements;
using EZCameraShake;
public class BallCollision : MonoBehaviour
{
    //public CamShake camShake;
    public Rigidbody rb;
    private static float CurrSpeed = BallMovement.speed;
    public AudioSource Hit;
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Hit.pitch = 1.0f;
    }

    private void OnCollisionEnter(Collision col)
    {
       
        if (CurrSpeed <= 25)
        {
            Hit.pitch = 1.0f;
        } 
        else if (CurrSpeed > 25 && CurrSpeed <= 75)
        {
            Hit.pitch = 1.6f;
        }
        else if (CurrSpeed > 75 && CurrSpeed < 200)
        {
            Hit.pitch = 2.5f;
        }
        else if(CurrSpeed > 200)
        {
            Hit.pitch = 3.0f;
        }
        Hit.Play(); // Sound effect on hit
        
        CameraShaker.Instance.ShakeOnce(2f, 2f, .1f, 0.7f);
        if (CurrSpeed < 750)
        {
            if (col.gameObject.CompareTag("Paddle"))
            {
                // Increase the speed of the ball
                CurrSpeed = rb.velocity.magnitude  * 1.6f;
                rb.velocity = rb.velocity.normalized * CurrSpeed;
                
                //rb.velocity *= CurrSpeed;
                Debug.Log("Collision detected. Speed increased to: " + CurrSpeed);

            }
        }
        else
        {
            CurrSpeed = 568.259f;
            rb.velocity = rb.velocity.normalized * CurrSpeed;


        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Speed"))
        {
            CurrSpeed= rb.velocity.magnitude  * 1.2f;
            rb.velocity = rb.velocity.normalized * CurrSpeed;
            
        }
        else if (other.gameObject.CompareTag("Inverse"))
        {
            rb.velocity = -rb.velocity;
        }
    }
}
