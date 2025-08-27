using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    private SceneSwitcher manager;
    private void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<SceneSwitcher>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("10") || other.gameObject.CompareTag("20") || other.gameObject.CompareTag("30"))
        {
            Debug.Log("Game Over!");
            manager.Credits();
        }
    }
}
