using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBarriers : MonoBehaviour
{
    public GameObject barrierPrefab;
    public Transform BarrierParent;

    private void Start()
    {
        Instantiate(barrierPrefab,new Vector3(-6.25f,-3f,-1f),Quaternion.identity).transform.SetParent(BarrierParent);
        Instantiate(barrierPrefab,new Vector3(-3.25f,-3f,-1f),Quaternion.identity).transform.SetParent(BarrierParent);
        Instantiate(barrierPrefab,new Vector3(-0.25f,-3f,-1f),Quaternion.identity).transform.SetParent(BarrierParent);
        Instantiate(barrierPrefab,new Vector3(2.75f,-3f,-1f),Quaternion.identity).transform.SetParent(BarrierParent);
        Instantiate(barrierPrefab,new Vector3(5.75f,-3f,-1f),Quaternion.identity).transform.SetParent(BarrierParent);
    }
}
