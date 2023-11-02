using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSlash : MonoBehaviour
{
    private PlayerStats playerStats;
    private Rigidbody2D rb;
    private Animator anim;


    void Start()
    {
        playerStats= GameObject.FindObjectOfType<PlayerStats>().GetComponent<PlayerStats>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        rb.velocity = transform.right * playerStats.effectMoveSpeed;
        anim.speed = playerStats.animationSpeed;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    
}
