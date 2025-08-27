using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rand = UnityEngine.Random;

public class SlotController : MonoBehaviour
{    

    // Start is called before the first frame update



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("0"))
        {
            Debug.Log($"You landed in slot 0, worth 100!");
        }
        else if (other.gameObject.CompareTag("1"))
        {
            Debug.Log($"You landed in slot 1, worth 15!");
        }
        else if (other.gameObject.CompareTag("2"))
        {
            Debug.Log($"You landed in slot 2, worth 250!");
        }
        else if (other.gameObject.CompareTag("3"))
        {
            Debug.Log($"You landed in slot 3, worth 0!");
        }
        else if (other.gameObject.CompareTag("4"))
        {
            Debug.Log($"You landed in slot 4, worth 500!");
        }
        else if (other.gameObject.CompareTag("5"))
        {
            Debug.Log($"You landed in slot 5, worth 75!");
        }
        else
        {
            Debug.Log($"Special Slot, Jackpot!");
        }


    }
}
