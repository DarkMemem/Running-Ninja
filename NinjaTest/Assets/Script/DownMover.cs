using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMover : MonoBehaviour
{
    public float speed;
    private Spawner spawner;
    private bool spawned;
    private ScoreManager sm;

    private void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
        spawner = FindObjectOfType<Spawner>();
        speed = spawner.speed;
    }

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
        speed += spawner.speedIncrease * Time.deltaTime;
        if (transform.position.y < 1.5 && !spawned)
        {
            sm.Score();
            spawner.SpawnedWave();
            Destroy(gameObject);
        }
    }
}

    