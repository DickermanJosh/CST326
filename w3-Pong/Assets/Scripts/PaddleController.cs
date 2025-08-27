using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class PaddleController : MonoBehaviour
{
    // Defining the Game Objects to plug the prefab into
    public GameObject leftPaddle;
    public GameObject rightPaddle;

    public GameObject topWall;
    public GameObject bottomWall;
    // int to control how fast the players can move the paddles
    public float moveSpeed = 1;
    
    private GameObject leftInstance;
    private GameObject rightInstance;

    private Rigidbody rbLeft;
    private Rigidbody rbRight;
    private BoxCollider bcLeft;
    private BoxCollider bcRight;

    

    
    
    // Awake is called once while the instance is being loaded instead of on the first frame
   private void Awake()
    {
        // Instantiating the paddles at the beginning of the game as leftInstance and rightInstance
        leftInstance = Instantiate(leftPaddle, new Vector3(-33.0f, 0.0f, 0.0f), quaternion.identity);
        rightInstance = Instantiate(rightPaddle, new Vector3(33.0f, 0.0f, 0.0f), quaternion.identity);
        rbLeft = leftInstance.GetComponent<Rigidbody>();
        rbRight = rightInstance.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float verticalVal1 = Input.GetAxis("Vertical");
        Vector3 force1 = Vector3.up * verticalVal1;

        rbLeft.AddForce(force1 * (moveSpeed * Time.deltaTime), ForceMode.Force);

        float verticalVal2 = Input.GetAxis("Vertical2");
        Vector3 force2 = Vector3.down * verticalVal2;
        rbRight.AddForce(force2 * (moveSpeed * Time.deltaTime), ForceMode.Force);
    }

  
}// End Class

















// using Input.GetKey to control the left and right paddles
//float verticalvalue = Input.GetAxis("Vertical")
// Left Paddle

//leftInstance.position +=
/*if (Input.GetKey(KeyCode.W))
{
    leftInstance.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
    
}
if (Input.GetKey(KeyCode.S))
{
    leftInstance.transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
}

// Right Paddle
if (Input.GetKey(KeyCode.UpArrow))
{
    rightInstance.transform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
}
if (Input.GetKey(KeyCode.DownArrow))
{
    rightInstance.transform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
}
*/


