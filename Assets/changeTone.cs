using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTone : MonoBehaviour
{
    public AudioClip sound;
    public GameObject piano;

    private void OnMouseDown()
    {
        AudioSource[] allKey = piano.GetComponentsInChildren<AudioSource>();

        foreach (AudioSource source in allKey) {
            source.clip = sound;
        }
    }
}
