using UnityEngine;

public class BowlingBall : MonoBehaviour
{
   public float forceMultiplier = 10f; 
    private Vector3 startMousePos;    
    private Vector3 direction;         
    private bool isDragging = false;  
    private Rigidbody rb;               

    void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            isDragging = true;
            startMousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        }
        else if (Input.GetMouseButtonUp(0)) 
        {
            if (isDragging)
            {
                isDragging = false;
                Vector3 endMousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
                direction = (startMousePos - endMousePos) * forceMultiplier; 
                rb.AddForce(direction, ForceMode.Impulse); 
            }
        }

        if (isDragging)
        {
            
            Vector3 dragPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            transform.position = new Vector3(dragPosition.x, dragPosition.y, transform.position.z);
        }
    }
}