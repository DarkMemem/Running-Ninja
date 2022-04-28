using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    private Spawner spawner;
    public GameObject sound;

    private void Start()
    {
        spawner = FindObjectOfType<Spawner>();
        speed = spawner.speed;
    }
    private void Update()
    {
        speed += spawner.speedIncrease * Time.deltaTime;
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.y < -6)
            Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(sound, transform.position, Quaternion.identity);
            other.GetComponent<Player>().health -= damage;
        }
    }
}
