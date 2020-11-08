using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
    private bool facingRight = true;
    private Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        anim.SetBool("Run", true);
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
        if (facingRight == false && moveInput < 0)
        {
            Flip();

        }
        else if (facingRight == true && moveInput > 0)
        {
            Flip();
            anim.SetBool("Run", true);
        }
        if (moveInput == 0)
        {
           anim.SetBool("Run", false);
        }
        
    }

   private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            Destroy(other.gameObject);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
