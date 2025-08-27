using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using Unity.Mathematics;
using UnityEditor.Rendering;
using UnityEngine;
using Random = UnityEngine.Random;

public class PaddleCollision : MonoBehaviour
{
    public Rigidbody rb;
    public BoxCollider bc;
    public GameObject ball;
    public Rigidbody ballRb;

    // Start is called before the first frame update

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        bc = gameObject.GetComponent<BoxCollider>();
    }

    /*private void OnCollisionEnter(Collision collision) // This is where I tried to get the ball to bounce in a different direction based on where it hit the paddle. I spent a lot of time here and was able to get the bounds of the paddle set up very -
    { // easily but no matter what I tried I couldn't seem to get the ball to actually change directions even if the computer knew it was hitting a certain part of the paddle. I'm not really sure what went so wrong here. I left it pretty messy because I tried and commented out so -
        // many different lines so I just decided to leave this here so you could get a better idea of where I went wrong and what I need to do to fix it.
        if (!collision.gameObject.CompareTag("Ball")) return;
        ballRb = ball.GetComponent<Rigidbody>();

        
        // Defining bounds and rotation
         var bound = bc.bounds;
        // Max and Min Y values of the paddles
         var maxY = bound.max.y;
         var minY = bound.min.y;
         //float x = Random.value < 0.5f ? 1.0f : 1.0f; // Randomized x dir for the ball

        //var colY = collision.GetContact(0).point.y; // ChatGPT helped me get the syntax for GetContact, which returns the point on contact that was made by the ball on the paddle
        //var normY = (colY - minY) / (maxY - minY); // normalizing the point of contact to scale between 0 and 1
        //Debug.Log($"ColY = {colY}\n normY = {normY}");
        Debug.Log($"maxY = {maxY}, minY = {minY}\ny pos of the ball is {ball.transform.position.y}");

        Vector3 bounceDir;
        if (maxY > 3.5f && maxY < 6.5f) // middle
        {
            ballRb.velocity = new Vector3(0f, 0f, 0f);
        }
        else if (maxY > 6.5f) // bottom
        {
            ballRb.velocity = new Vector3(0f,60f, 0f);
        }
        else // top
        {
            Quaternion rotation = quaternion.Euler(0f,-60f,0f);
            if (collision.transform.position.x < 0)
            {
                //ballRb.velocity = new Vector3(0f,60000f,0f);
                //float dist = collision.gameObject.transform.position.y - (maxY - minY);
                //ballRb.velocity = new Vector3(10f, dist * 20f,0f);
                
                //ballRb.AddForce(-60f,-60f,-60f);
                Debug.Log($"pos: {collision.transform.position.x} Top of Paddle");
                bounceDir = rotation * Vector3.right;
                ballRb.AddForce(bounceDir * 100000f, ForceMode.Force);
            }
            else
            {
                ballRb.velocity = new Vector3(0f,60000f,0f);
                //float dist = collision.gameObject.transform.position.y - (maxY - minY);
                //ballRb.velocity = new Vector3(-10f, dist * 20f,0f);
                Debug.Log($"pos: {collision.transform.position.x} Top of Paddle");
                bounceDir = rotation * Vector3.up;
                ballRb.AddForce(bounceDir * 10000f, ForceMode.Force);
            }
            
            //ballRb.velocity = new Vector3(60f*1000,0f, 0f);

        }*/
        
        
        
        
        
        
        
        /*Quaternion rotate = quaternion.Euler(0f, -60f, 0f);
        Vector3 bounceDir = rotate * Vector3.up;
        ballRb.AddForce(bounceDir*1000f,ForceMode.Force);*/
        
        /*if (normY <= 0.33f) //applies the correct vector to the ball depending on where it hit the paddle;
        {
            //rotate = quaternion.Euler(60f, 60f, 0f); // 0.0 - 0.33
            ballRb.velocity = new Vector3(0f, -normY * 200f,0f);
        }
        else if (normY <= 0.66f && normY > 0.33f)// 0.34 - 0.66
        {
            //rotate = quaternion.Euler(0f, 0f, 0f);
            ballRb.velocity = new Vector3(0f, normY * 2f,0f);
        }
        else
        {
            //rotate = Quaternion.Euler(-60f,-60f,0f);// 0.67 - 1.0
            ballRb.velocity = new Vector3(0f, normY * 200f,0f);
        }
        //var bounceDir = ball.transform.InverseTransformDirection(rotate*Vector3.up)*1000f;
        //ballRb.velocity = bounceDir * ballRb.velocity.magnitude;
        // Debug.Log($"bounceDir = {bounceDir}");
    }*/
}
