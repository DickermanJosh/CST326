using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rand = UnityEngine.Random;
public class BallSpawner : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        //Vector3 spawnPos = GetComponent<Transform>().position;

        Instantiate(ball, GetComponent<Transform>().position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Rand.value < 0.5 ? -8.0f : 8.0f; // Random x pos for the ball

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 spawnPos = new Vector3(x, 3, 0f);
            //Vector3 spawnPos = GetComponent<Transform>().position;
            Instantiate(ball, spawnPos, Quaternion.identity);
        }

/*        if (Input.GetKeyDown("space"))
        {
            float x = Rand.value < 0.5f ? -9.0f : 9.0f;
            Spawn(x, 0);
        }*/
    }

    /*private void Spawn(float x, float y)
    {
        ballInstance = Instantiate(gameObject, new Vector3(x, y, 0f), Quaternion.identity);
    }*/
}
