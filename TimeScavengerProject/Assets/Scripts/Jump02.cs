using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump02 : MonoBehaviour {

    public float jumpSpeed = 8f;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    


    private Rigidbody2D rb;

   

    // Use this for initialization
    void Awake () {

        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
        if (Input.GetKeyDown(KeyCode.Space) && isTouchingGround)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }






    }
}
