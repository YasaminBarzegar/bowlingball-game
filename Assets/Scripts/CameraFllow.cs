using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFllow : MonoBehaviour
{
   public Transform ball; 
    public Vector3 offset = new Vector3(0, 2, -5); 
    public float smoothSpeed = 5f; 

    void LateUpdate()
    {
        if (ball != null)
        {
            
            Vector3 targetPosition = ball.position + offset;

            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

            transform.LookAt(ball.position);
        }
    }
}
