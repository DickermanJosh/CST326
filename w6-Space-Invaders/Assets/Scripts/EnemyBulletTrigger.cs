using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBulletTrigger : MonoBehaviour
{
    private ExplosionSounds deathSounds;
    private PlayerSpawner playerSpawner;
    private void Start()
    {
        deathSounds = GameObject.Find("Game Manager").GetComponent<ExplosionSounds>();
        playerSpawner = GameObject.Find("Game Manager").GetComponent<PlayerSpawner>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            deathSounds.explodePlayer();
            Destroy(other.gameObject,0.1f);
            Destroy(this.gameObject);
            playerSpawner.playerLives -= 1;
            playerSpawner.Respawn();
        }
        else if (other.gameObject.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
        else if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(this.gameObject);
        }
    }

}
