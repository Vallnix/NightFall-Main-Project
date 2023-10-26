using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    [SerializeField] private float rate = 1f;
    [SerializeField] GameObject zombiePrefab;
    [SerializeField] private bool spawning = true;

    float xMin;
    float yMin;

    private void Start()
    {
        StartCoroutine(Spawner());
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
