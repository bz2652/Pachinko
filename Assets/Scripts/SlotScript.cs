using UnityEngine;

public class SlotScript : MonoBehaviour
{
    public bool hasTouchedSlot = false;
    public GameManagerScript gameManager;
    public AudioSource Slot;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Slot = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (hasTouchedSlot == false)
            {
                int randomPoints = Random.Range(0, 2);

                if (randomPoints == 0)
                {
                    gameManager.AddScore(5);
                }
                else
                {
                    gameManager.AddScore(-5);
                }
                
                Slot.Play();
                hasTouchedSlot = true;
            }
            else
            {
                return;
            }
        }
    }
}
