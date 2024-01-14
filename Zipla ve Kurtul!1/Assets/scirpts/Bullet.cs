using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;

    private Rigidbody2D rb;    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  
    private void FixedUpdate()
    {
        rb.velocity = -transform.right * bulletSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
	gameObject.SetActive(false);
    }
}
