using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    float rate = 5f;
    [SerializeField] GameObject zombiePrefab;
    [SerializeField] private bool spawning = true;


    private void Start()
    {
        StartCoroutine(Spawner());


    }
    private void Update()
    {
      
    }
   

    private IEnumerator Spawner()
    {
        WaitForSeconds wait = new WaitForSeconds(rate);

        while (spawning)
        {
            yield return wait;

            Instantiate(zombiePrefab, transform.position, Quaternion.identity);
        }
    }
   
}
