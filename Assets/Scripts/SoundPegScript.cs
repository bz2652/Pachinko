using UnityEngine;

public class SoundPegScript : MonoBehaviour
{
    public AudioClip audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            audioSource.Play();
        }
    }
}
