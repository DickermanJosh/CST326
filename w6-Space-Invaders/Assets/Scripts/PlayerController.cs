using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerController : MonoBehaviour
{
    private Animator anim;
    public GameObject bulletPrefab;
    public Transform shootOffsetTransform;
    public float moveSpeed = 1;
    public AudioSource fire;
    private Rigidbody rb;
    private float getAxis;
    private Vector3 move;
    
    // Start is called before the first frame update
    private void Start()
    { 
        rb = this.gameObject.GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject shot = Instantiate(bulletPrefab, shootOffsetTransform.position, Quaternion.identity);
            anim.SetTrigger("isShooting");
            fire.Play();
            Destroy(shot, 8f);
        }
    }
    void FixedUpdate()
    {
        getAxis = Input.GetAxis("Horizontal");
        move = moveSpeed * new Vector3(getAxis, 0f, 0f);
        rb.AddForce(move * (moveSpeed * Time.deltaTime),ForceMode.Force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            anim.SetBool("isDead",true);
        }
    }
}
