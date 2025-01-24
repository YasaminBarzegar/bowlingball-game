using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = FindObjectOfType<LevelManager>(); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            levelManager.LoadNextLevel(); 
        }
    }
}