using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    [Range(1, 10)] public float spawnInterval = 2;
    private float cooldown = 0;

    // Update is called once per frame
    void Update()
    {
        if (cooldown <= 0)
        {
            Vector2 offset = new Vector2(0, Random.Range(-5, 5));
            Instantiate(enemy, offset, Quaternion.identity);
            cooldown = spawnInterval;
            Debug.Log("Spawned enemy!");
        }
        else
        {
            cooldown -= Time.deltaTime;
            Debug.Log("Cooldown is now: " + cooldown);
        }
    }
}
