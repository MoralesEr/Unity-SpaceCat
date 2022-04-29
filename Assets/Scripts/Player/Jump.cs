using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D playerRB;
    private float gravityModifier;
    private float jumpforce = 7f;
    private bool isOnGround = true;
    private int jumps;
    private AudioSource controlAudio;
    public AudioClip jumpSound;
    private float jumpInput;
    void Start()
    {
        controlAudio = GetComponent<AudioSource>();
        playerRB = GetComponent<Rigidbody2D>();
        Physics.gravity *= gravityModifier;
        jumpInput = Input.GetAxis("Vertical");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRB.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
            jumps -= 1;
            isOnGround = false;
            controlAudio.PlayOneShot(jumpSound, 0.05f);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "ground") {
            jumps = 2;
            isOnGround = true;
        }

    }
}
