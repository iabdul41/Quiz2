using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float xBound = 50.0f;
    private float yBound = 20.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > xBound || transform.position.x < - xBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y > yBound || transform.position.x < -yBound)
        {
            
            Destroy(gameObject);

        }
    }
}
