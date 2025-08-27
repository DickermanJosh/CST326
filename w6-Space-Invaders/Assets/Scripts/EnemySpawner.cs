using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemyParentPrefab;
    // --------------------------------------------------------------------------
    private void Start()
    {
        spawnParent();
    }
    // --------------------------------------------------------------------------
    private void spawnParent()
    {
        Instantiate(enemyParentPrefab, new Vector3(0f, 2.7f, 0f), Quaternion.identity);
    }
    // --------------------------------------------------------------------------
  
}
