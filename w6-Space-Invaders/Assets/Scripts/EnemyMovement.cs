using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed;
    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            transform.Translate(Vector3.right * (moveSpeed * Time.deltaTime));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Chaning direction and moving down when making contact with a wall
        if (other.gameObject.CompareTag("Wall"))
        {
            // change direction and move toward player
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.5f, transform.position.z);
            moveSpeed *= -1;
            
            // Increasing movement speed as the enemies are destroyes
            if (transform.childCount < 35 && transform.childCount > 5)
            {
                moveSpeed *= 1.4f;
            }
            else if (transform.childCount <= 5)
            {
                moveSpeed *= 1.1f;
            }
            
        }
    }
}
