using UnityEngine;
using UnityEngine.SceneManagement; 

public class LevelManager : MonoBehaviour
{
    
    public void LoadNextLevel()
    {
        SceneManager.LoadScene("Level2"); 
    }
}
