using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditTimer : MonoBehaviour
{
    private SceneSwitcher manager;
    private void Start()
    {
        manager = GameObject.Find("Game Manager").GetComponent<SceneSwitcher>();
    }

    // Update is called once per frame
    void Update()
    {
        int wholeSecond = (int)Math.Floor(Time.timeSinceLevelLoad);
        if (wholeSecond > 5)
        {
            manager.Menu();
        }
    }
}
