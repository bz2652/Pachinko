using UnityEngine;

public class BugScript : MonoBehaviour
{
    public AudioSource Eating;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Eating = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Eating.Play();
        }
    }
}
