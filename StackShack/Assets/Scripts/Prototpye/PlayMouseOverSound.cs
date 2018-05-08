using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMouseOverSound : MonoBehaviour {

    public AudioSource playSound;
    public AudioClip hover;

    public void playOnHover()
    {
        playSound.clip = hover;
        playSound.Play();

    }
}
