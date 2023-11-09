using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyAttack : MonoBehaviour
{
    public GameObject player;
    public float speed;
    
    private float distance;
    int kills = 0;
   

    [SerializeField] GameManager manager;


    // Update is called once per frame
    void Update()
    {
        
            distance = Vector2.Distance(transform.position, player.transform.position);

            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            GameManager.instance.GameOver();
            Destroy(player);
            player = null;
            Debug.Log("Hit");
        }
        else 
        {
        Destroy(gameObject);
        GameManager.instance.IncreaseKills(1);
        kills += kills;
        GameManager.instance.IncreaseKills(kills);
        }
    }
}
