using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Dynamic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
     public float speed = 0;
     public TextMeshProUGUI countText;
     public GameObject winTextObj;
     
    private int _count;
    private Rigidbody _rb;
    private float _moveX;
    private float _moveY;
    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
       _count = 0;
       SetCountText();
       
       winTextObj.SetActive(false);
    }

    // Update is called once per frame
    private void OnMove(InputValue movementValue)
    {
        var movementVector = movementValue.Get<Vector2>();

        _moveX = movementVector.x;
        _moveY = movementVector.y;
    }

    private void SetCountText()
    {
        countText.text = "Score: " + _count.ToString();

        if (_count >= 12)
        {
            winTextObj.SetActive(true);
        }
    }
    private void FixedUpdate()
    {
        var movement = new Vector3(_moveX, 0.0f, _moveY);
        _rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Pickup")) return; // only remove object if the object has the "Pickup" tag
        other.gameObject.SetActive(false);  // removing an object when it comes into contact with the player object
        _count += 1;
        SetCountText();

    }
    
    
}
