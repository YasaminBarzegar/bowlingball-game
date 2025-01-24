using UnityEngine;

public class BallMoveController : MonoBehaviour
{
    
     private Vector3 startPosition;   
    private Vector3 endPosition;     
    private bool isDragging = false; 

    

    public float forceMultiplier = 10f; 

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            startPosition = Input.mousePosition; 
            isDragging = true;
        }

       
        if (Input.GetMouseButtonUp(0) && isDragging)
        {
            endPosition = Input.mousePosition; 
            LaunchBall(); 
            isDragging = false; 
        }
    }

    void LaunchBall()
    {
        Vector3 direction = (startPosition - endPosition).normalized; 
        float distance = Vector3.Distance(startPosition, endPosition); 

        rb.useGravity = true; 
        rb.AddForce(new Vector3(direction.x, 0, direction.y) * distance * forceMultiplier); 
    }
}