using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        turning(other.transform);
        Destroy(gameObject);
    }

    void turning(Transform otherObject)
    {
        Debug.Log(otherObject.gameObject.name);
        Debug.Log("RunThis");
        //otherObject.eulerAngles = Vector3.zero;  
        otherObject.Rotate(0, 180, 0, Space.World);
    }
}
