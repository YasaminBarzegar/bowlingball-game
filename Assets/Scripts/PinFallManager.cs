using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinFallManager : MonoBehaviour
{    
    private bool hasScored = false; 
    private float initialHeight; 

    //GameObject[] pins = GameObject.FindGameObjectsWithTag("Pin");

    //private bool SetActive = true;

    void Start()
    {
        initialHeight = transform.position.y; 
    }

    void Update()
    {
         
        
        if (!hasScored && transform.position.y < initialHeight - 0.02f)
        {
            hasScored = true; 
            ScoreManager.instance.AddScore();
           // Pin.SetActive(false);
        }
    }
}
