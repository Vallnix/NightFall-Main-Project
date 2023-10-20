using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float moveSpeed = 0.8f;

    public Rigidbody2D rb;

    private Vector2 mDirection;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
    }

    void FixedUpdate()
    {
        Movement();
    }

    void Inputs()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        float yMove = Input.GetAxisRaw("Vertical");

        mDirection = new Vector2(xMove, yMove); //Come Back
    }

    void Movement()
    {
        rb.velocity = new Vector2(mDirection.x * moveSpeed, mDirection.y * moveSpeed);
    }
}
