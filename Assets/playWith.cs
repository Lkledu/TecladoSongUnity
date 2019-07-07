using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playWith : MonoBehaviour
{
    AudioSource tone;

    private void Start()
    {
        tone = GetComponent<AudioSource>();
        tone.Stop();
    }

    private void OnMouseDown()
    {
        if (!tone.isPlaying)
        {
            tone.Play();
        }
        else {
            tone.Stop();
        }
        
    }
}
