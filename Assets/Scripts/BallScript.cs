using System;
using NUnit.Framework.Constraints;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public PlayerScript player;
    public bool powerUp = false;
    
    public AudioSource powerUpSound;
   
    void Start()
    {
      powerUpSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Check if it hit a specific object using a Tag
        if (collision.gameObject.CompareTag("Exit"))
        {
            player.canSpawn = true;
            FindAnyObjectByType<GameManagerScript>().PlayExitSound();
            foreach (PegScript x in FindObjectsOfType<PegScript>())
            {
                x.hasTouchedPeg = false;
            }
            foreach (SlotScript x in FindObjectsOfType<SlotScript>())
            {
                x.hasTouchedSlot = false;
            }
            // Destroy the object
            Destroy(gameObject); 
        }

        if (collision.gameObject.CompareTag("Skull"))
        {
            player.canSpawn = false;
            FindAnyObjectByType<GameManagerScript>().GameOver();
            Destroy(gameObject);
        }
        
        if (collision.gameObject.CompareTag("Boost"))
        {
            powerUp = true;
            powerUpSound.Play();
        }

        if (collision.gameObject.CompareTag("Bug"))
        {
            player.canSpawn = true;
            Destroy(gameObject); 
        }
    }
}
