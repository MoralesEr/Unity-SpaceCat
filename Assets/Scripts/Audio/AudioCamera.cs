using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioCamera : MonoBehaviour
{
    private AudioSource audioController;
    public AudioClip musica;
    void Start()
    {
        audioController = GetComponent<AudioSource>();
        audioController.PlayOneShot(musica, 0.03f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
