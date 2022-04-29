using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cascabel : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "cascabel") {
            Destroy(collision.gameObject);
            ScoreScript.scoreValue += 1;
        }
    }
}
