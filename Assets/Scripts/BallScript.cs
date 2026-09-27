using System;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public PlayerScript player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if it hit a specific object using a Tag
        if (collision.gameObject.CompareTag("Exit"))
        {
            player.canSpawn = true;
            // Destroy the object
            Destroy(gameObject); 
        }
    }
    
}
