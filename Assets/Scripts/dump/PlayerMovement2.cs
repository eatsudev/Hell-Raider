using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    public float speed;
    private float Move;
    public float Jump;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    //Animator myAnimation;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //myAnimation = GetComponent<Animator>();
    }

    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(Move * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));
        }
        Flip();
    }
    private void Flip()
    {
        if (isFacingRight && Move < 0f || !isFacingRight && Move> 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }
}
