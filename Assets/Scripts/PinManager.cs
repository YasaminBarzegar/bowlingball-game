using UnityEngine;

public class PinManager : MonoBehaviour
{
   public GameObject pinPrefab; 
    public Vector3 startPosition = new Vector3(0, 0, 10); 
    public float pinSpacing = 0.3f;


    void Start()
    {
         SetupPins();
    }
    void SetupPins()
    {
        int totalRows = 4; 

        int pinCount = 0; 

        for (int row = 0; row < totalRows; row++) {

            for (int col = 0; col <= row; col++) 
            {
                if (pinCount >= 10) break; 
              
                Vector3 position = startPosition + new Vector3(col * pinSpacing - (row * pinSpacing / 2), 0, row * pinSpacing);
                Instantiate(pinPrefab, position, pinPrefab.transform.rotation); 
                pinCount++;
            }
        }
    }
}