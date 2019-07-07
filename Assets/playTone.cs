using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playTone : MonoBehaviour
{
    AudioSource tone;

    private void Start()
    {
        tone = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        tone.Play();
    }
}
