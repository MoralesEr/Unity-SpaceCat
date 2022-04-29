using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCascabel : MonoBehaviour
{
    private AudioSource audioController;
    public AudioClip acascabel;
    void Start()
    {
        audioController = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("cascabel"))
        {
            audioController.PlayOneShot(acascabel, 0.07f);
        }

    }
}
