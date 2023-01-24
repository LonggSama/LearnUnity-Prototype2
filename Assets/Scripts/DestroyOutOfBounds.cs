using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;
    private float rightBound = 20.0f;
    private float leftBound = -20.0f;
    public bool loseLive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            GameManager.liveCheck = true;
        }
        else if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
            GameManager.liveCheck = true;
        }
        else if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
            GameManager.liveCheck = true;
        }
    }

}
