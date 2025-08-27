using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDestroyer : MonoBehaviour
{
    private int count = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBullet") || other.gameObject.CompareTag("EnemyBullet"))
        {
            count++;
            if (count >= 4)
            {
                Destroy(gameObject);
            }
        }
    }
}
