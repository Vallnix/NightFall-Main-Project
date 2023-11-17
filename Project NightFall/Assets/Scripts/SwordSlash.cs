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
    //Sword Slash Code involved ideas and coding from these
    //https://www.youtube.com/watch?v=5MTaVHecYfI&ab_channel=GameDevKnight
    // https://www.youtube.com/watch?v=giJKCl-GVrU&t=159s&ab_channel=MuddyWolf

        playerStats = GameObject.FindObjectOfType<PlayerStats>().GetComponent<PlayerStats>();
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
