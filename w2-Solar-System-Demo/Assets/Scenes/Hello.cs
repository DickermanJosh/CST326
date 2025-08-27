using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(message: "Hello Unity! frame: "+ Time.frameCount);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(message: "Hello Unity! frame: " + Time.frameCount);

    }
}
