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
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(slashEffect, firePoint.position, firePoint.rotation);
        }
    }
    
}
