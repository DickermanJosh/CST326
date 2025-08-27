using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class ScoreLeft : MonoBehaviour
{
    public Modifiers mods;
    public TextMeshProUGUI leftScore;
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

            //Debug.Log($"Collision detected, RightScore = {leftScore}");
            count++;
            leftScore.text = count.ToString();
            //Debug.Log($"RightScore = {leftScore}");


            if (count < 11)
            {
                BallMovement ballMovement = GameObject.Find("Manager").GetComponent<BallMovement>(); // Chat GPT showed me how to use the "Find" keyword
                const float x = 1.0f;
                float y = Random.Range(-0.8f, 0.8f);
                ballMovement.Respawn(x, y);
            }
            else
            {
                win.text = "Player 1 wins!";
            }

            if (count <= 3)
            {
                leftScore.color = Color.green;
            }
            else if (count > 3 && count <= 6)
            {
                leftScore.color = Color.yellow;
            }
            else if (count > 6 && count <= 8)
            {
                leftScore.color = Color.magenta;
            }
            else if (count > 8)
            {
                leftScore.color = Color.red;
            }
            
        }
            
    }
        
        
}

