using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public int playerLives = 3;
    public GameObject playerPrefab;
    public SceneSwitcher manager;
    private void Start()
    {
        Respawn();
        manager = GameObject.Find("Game Manager").GetComponent<SceneSwitcher>();
    }

    // Update is called once per frame
    public void Respawn()
    {
        if (playerLives >= 1)
        {
            Instantiate(playerPrefab, new Vector3(0f, -3.75f, -1f), Quaternion.identity);
        }
        else
        {
            Debug.Log("Game Over");
            manager.Credits();
        }
    }
}
