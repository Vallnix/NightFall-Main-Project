using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Transform firePoint;
    public GameObject slashEffect;


    private void Update()
    {
        //Sword Slash Code involved ideas and coding from these
        //https://www.youtube.com/watch?v=5MTaVHecYfI&ab_channel=GameDevKnight
        // https://www.youtube.com/watch?v=giJKCl-GVrU&t=159s&ab_channel=MuddyWolf

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(slashEffect, firePoint.position, firePoint.rotation);
        }
    }
    
}
