using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public GameManager gameManager; 

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pin")) 
        {
            StartCoroutine(ResetAfterDelay()); 
        }
    }

    IEnumerator ResetAfterDelay()
    {
        yield return new WaitForSeconds(3f); 
        gameManager.ResetBallAndPins(); 
    }
}
