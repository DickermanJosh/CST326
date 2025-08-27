using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerBulletTrigger : MonoBehaviour
{
    private ExplosionSounds deathSounds;
    private int score;
    private String scoreString;
    private ScoreManager scoreM;
    
    private void Start()
    {
        deathSounds = GameObject.Find("Game Manager").GetComponent<ExplosionSounds>();
        scoreM = GameObject.Find("Game Manager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("10")) // Skull Enemy
        {
            deathSounds.explodeEnemy();
            Destroy(other.gameObject,0.1f);
            scoreM.ScoreUpdate(10);
            Destroy(gameObject); // Destroy the current game object
        }
        else if (other.gameObject.CompareTag("20")) // Bug Enemy
        {
            deathSounds.explodeEnemy();
            Destroy(other.gameObject,0.1f);
            scoreM.ScoreUpdate(20);
            Destroy(gameObject); // Destroy the current game object
        }
        else if (other.gameObject.CompareTag("30")) // Squid Enemy
        {
            deathSounds.explodeEnemy();
            Destroy(other.gameObject,0.1f);
            scoreM.ScoreUpdate(30);
            Destroy(gameObject); // Destroy the current game object
        }
        else if (other.gameObject.CompareTag("UFO")) // UFO
        {
            deathSounds.explodeEnemy();
            Destroy(other.gameObject,0.1f);
            scoreM.ScoreUpdate(250); // TODO: Make Random between 50 - 500 in blocks of 50s (low priority)
            Destroy(gameObject); // Destroy the current game object
        }
        else if (other.gameObject.CompareTag("EnemyBullet")) // Enemy Bullet
        {
            Destroy(other.gameObject);
            Destroy(gameObject); // Destroy the current game object
        }
        else if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(this.gameObject);
        }
    }
}
