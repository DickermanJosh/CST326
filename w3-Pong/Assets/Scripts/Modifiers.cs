using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;
public class Modifiers : MonoBehaviour
{
    public GameObject Inverse;
    public GameObject SpeedBoost;
    // Start is called before the first frame update
    private void Start()
    {
        //SpawnMods();
    }

    public void SpawnMods()
    {
        float x = Random.Range(-15f, 15f);
        float y = Random.Range(-15f, 15f);
        Instantiate(Inverse, new Vector3(x, y, 0f), quaternion.identity);
        x = Random.Range(-15f, 15f);
        y = Random.Range(-15f, 15f);
        Instantiate(SpeedBoost, new Vector3(x, y, 0f), quaternion.identity);
    }

    public void DestroyMods()
    {
        Destroy(Inverse);
        Destroy(SpeedBoost);
    }
}
