using System;
using UnityEngine;

public class PegScript : MonoBehaviour
{
    public GameManagerScript gameManager;
    public bool hasTouchedPeg = false;
    public AudioSource Boing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Boing = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BallScript ball = collision.gameObject.GetComponent<BallScript>();
            SpriteRenderer spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.color = Color.orange;
            if (hasTouchedPeg == false)
            {
                if (ball.powerUp == true)
                {
                    gameManager.AddScore(2);
                }
                else
                {
                    gameManager.AddScore(1);
                }
                
                Boing.Play();
                hasTouchedPeg = true;
            }
            else
            {
                return;
            }
        }
    }

    public void PowerUp()
    {
        gameManager.AddScore(2);
    }
}
