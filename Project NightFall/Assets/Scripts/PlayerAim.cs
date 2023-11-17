using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAim : MonoBehaviour
{

    public float rotationSpeed = 5f;
    // Update is called once per frame
    void Update()
    {
        //Sword Slash Aim Code involved ideas and coding from these
        //https://www.youtube.com/watch?v=5MTaVHecYfI&ab_channel=GameDevKnight
        // https://www.youtube.com/watch?v=giJKCl-GVrU&t=159s&ab_channel=MuddyWolf

        Vector2 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation,rotation, rotationSpeed * Time.deltaTime);

    }
   
}
