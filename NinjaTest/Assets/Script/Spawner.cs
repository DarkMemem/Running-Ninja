using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] blocklist;

    public float speed;
    public float speedIncrease;
    public float maxSpeed;

    private void Update()
    {
        if (speed < maxSpeed)
            speed += speedIncrease * Time.deltaTime;
    }

    public void SpawnedWave()
    {
        Time.timeScale = 1f;
        int rand = Random.Range(0, blocklist.Length);
        Instantiate(blocklist[rand], new Vector3(0, 10, 0), Quaternion.identity);
    }
}

