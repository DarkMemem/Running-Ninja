using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool canMove;

    public float speed;
    public float minX, maxX;
    public int health;
    public int Hearts;
    public Image[] hearts;
    public Sprite FullHeart;
    public Sprite EmptyHeart;
    public GameObject panel;

    public Vector2 targetPos;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void MovePlayer()
    {
        if ( transform.position.x > minX)
        {
            targetPos = new Vector2(minX, transform.position.y);
            transform.rotation = Quaternion.Euler(180, 0, 270);
        }
        else if (transform.position.x < maxX)
        {
            targetPos = new Vector2(maxX, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    public void Update()
    {
        
        if (transform.position.x > minX && canMove)
        {
            targetPos = new Vector2(minX, transform.position.y);
            transform.rotation = Quaternion.Euler(180, 0, 270);
        }
        else if (transform.position.x < maxX && canMove)
        {
            targetPos = new Vector2(maxX, transform.position.y);
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        if (health > Hearts)
            health = Hearts;

        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
                hearts[i].sprite = FullHeart;
            else
                hearts[i].sprite = EmptyHeart;
        }

        if (health <= 0)
        {
            Time.timeScale = 0f;
            panel.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            anim.SetTrigger("damage");
        }
    }
}
