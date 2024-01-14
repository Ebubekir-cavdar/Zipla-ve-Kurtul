using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    public float speed;
    public float jumpForce;
    int zipla;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&zipla>0)
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(new Vector2(0, jumpForce));
            zipla--;
	    
        }
	
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontal*Time.deltaTime*speed,rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("platform"))
        {
            zipla = 2;
	    
        }
    }
}