using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSounds : MonoBehaviour
{
    public AudioSource enemyExplosion;

    public AudioSource playerExplosion;

    private SceneSwitcher switcher;
    public void explodePlayer()
    {
        playerExplosion.Play();
        while (!playerExplosion.isPlaying)
        {
            switcher.Credits();
        }
        
    }

    public void explodeEnemy()
    {
        enemyExplosion.Play();
    }
    
}
