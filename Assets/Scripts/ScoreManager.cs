using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager instance; 
    public int score = 0; 
    public TextMeshProUGUI scoreText; 

    void Awake()
    {
        
        if (instance == null)
            instance = this;
    }

    public void AddScore()
    {
        score++; 
        UpdateScoreUI(); 
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }

}
