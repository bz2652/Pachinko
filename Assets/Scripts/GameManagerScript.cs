using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text gameOverText;
    public AudioSource exit;
    public AudioSource skull;

    public int Score = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AddScore(int points)
    {
        Score += points;
        scoreText.text = "Score: " + Score.ToString();
    }
    
    public void GameOver()
    {
        Debug.Log("GameOver");
     
        gameOverText.gameObject.SetActive(true);
        Invoke("RestartGame", 3f);
    }
    
    public void PlayExitSound()
    {
        Debug.Log("Play Exit Sound");
        exit.Play();
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
