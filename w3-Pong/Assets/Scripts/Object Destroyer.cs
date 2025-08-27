using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public MeshRenderer mesh;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
