using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    private float inY = -1.84f;
    private float inX = -1.73f;
    private float maxX = 8.66f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -7) {
            transform.position = new Vector2(inX, inY);
        }

        if (transform.position.x > maxX)
        {
            transform.position = new Vector2(maxX, transform.position.y);
        }
        else if (transform.position.x < -maxX) {
            transform.position = new Vector2(-maxX, transform.position.y);
        }
    }
}
