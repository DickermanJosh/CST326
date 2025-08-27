using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public Modifiers mods;
    private GameObject ballInstance;
    public GameObject ball;
    public Rigidbody rb;
    public SphereCollider bc;
    public static float speed = 500; // speed multiplier for the ball
    private void Awake() // Instantiating the ball and referencing its components before the game starts
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f; // Randomized x dir for the ball
        float y = Random.value < 0.5f ? Random.Range(-0.8f, -0.2f) : Random.Range(0.2f, 0.8f); // Randomized y dir for the ball
        Respawn(x,y); // Calling Respawn for the first Instance of the ball
    }

    public void Respawn(float x, float y) { // Respawn method for when a player scores
        Destroy(ballInstance); // Destroys the current ball so that it doesn't keep taking up memory
        ballInstance = Instantiate(ball, new Vector3(0.0f, 0.0f, -0.1f), quaternion.identity); // Instantiate a new ball;
        rb = ballInstance.GetComponent<Rigidbody>();
        bc = ballInstance.GetComponent<SphereCollider>();
        rb.AddForce(new Vector3(x * speed, y * speed, 0.0f));
        mods.SpawnMods();
    }
}


