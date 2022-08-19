using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;

    public static bool gameOver;
    void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        jump();
        if (gameOver == true)
        {
            Time.timeScale = 0f;
        }
        angler();
    }

    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rb.velocity = Vector2.up * speed;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver = true;
    }

    void angler()
    {
        if (GameStart.gameStarted == true)
        {
            float angle = 35;

            if (rb.velocity.y < 0)
            {
                angle = Mathf.Lerp(35, -60, -(rb.velocity.y) / 10);
            }

            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
            
    }
}
