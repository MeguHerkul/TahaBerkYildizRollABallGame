using UnityEngine;

public class Star_Rotator : MonoBehaviour
{

    
    void Update()
    {
        
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }

}
