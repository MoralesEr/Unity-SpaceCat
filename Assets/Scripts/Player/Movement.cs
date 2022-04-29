using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private float horizontalInput;
    private float speed = 3f;
    public SpriteRenderer spriteRenderer;



    private void Start()
    {
    }
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false;
        }
        else if(horizontalInput < 0){
            spriteRenderer.flipX = true;
        }
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * speed);

    }

}
