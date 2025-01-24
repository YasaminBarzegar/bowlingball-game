using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform ball; 
    public Transform ballStartPos; 
    public List<GameObject> pins; 
    public float minPinHeight = 0.1f; 

    private List<Vector3> pinStartPositions = new List<Vector3>(); 
    private List<Quaternion> pinStartRotations = new List<Quaternion>(); 

      void Start()
    {
       
        foreach (GameObject pin in pins)
        {
            pinStartPositions.Add(pin.transform.position);
            pinStartRotations.Add(pin.transform.rotation);
        }
    }

     public void ResetBallAndPins()
    {
       
        ball.position = ballStartPos.position;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero; 
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;

        
        for (int i = pins.Count - 1; i >= 0; i--)
        {
           
            if (pins[i].transform.position.y < minPinHeight)
            {
                Destroy(pins[i]); 
                pins.RemoveAt(i);
            }
            else
            {
              
                pins[i].transform.position = pinStartPositions[i];
                pins[i].transform.rotation = pinStartRotations[i];
                pins[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
                pins[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            }
        }
    }

     void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) 
        {
            ResetBallAndPins();
        }
    }


}
