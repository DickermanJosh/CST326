using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;
public class ScoreRight : MonoBehaviour
{
    
    public TextMeshProUGUI rightScore;
    private int count = 0;
    public BoxCollider bc;
    public TextMeshProUGUI win;
    private void Start()
    {
        bc = gameObject.GetComponent<BoxCollider>();
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Ball"))
        {

            Debug.Log($"Collision detected, RightScore = {rightScore}");
            count++;
            rightScore.text = count.ToString();
            Debug.Log($"RightScore = {rightScore}");
            if (count < 11)
            {
                BallMovement ballMovement = GameObject.Find("Manager").GetComponent<BallMovement>(); // Chat GPT showed me how to use the "Find" keyword
                const float x = -1.0f;
                float y = Random.Range(-0.8f, 0.8f);
                //Invoke("Respawn", 2.0f); // Chat GPT also showed me how to use the "Invoke" keyword
                ballMovement.Respawn(x, y);
            }
            else
            {
                win.text = "Player 2 wins!";
            }
            
            if (count <= 3)
            {
                rightScore.color = Color.green;
            }
            else if (count > 3 && count <= 6)
            {
                rightScore.color = Color.yellow;
            }
            else if (count > 6 && count <= 8)
            {
                rightScore.color = Color.magenta;
            }
            else if (count > 8)
            {
                rightScore.color = Color.red;
            }
        }

    }
}
