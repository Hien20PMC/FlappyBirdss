using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Sound : MonoBehaviour
{
    public AudioClip Wing;
    public AudioClip Point;
    public AudioClip Hit;
    public AudioClip Shot;
    private AudioSource Sounds;
    public static Sound s_Sound;
    // Start is called before the first frame update
    public void Awake()
    {
        s_Sound = this;
    }
    void Start()
    {
        Sounds = GetComponent<AudioSource>();
    }

    public void SoundMovement()
    {
        Sounds.PlayOneShot(Wing);
    }

    public void SoundPoint()
    {
        Sounds.PlayOneShot(Point);
    } 
    public void SoundHit()
    {
        Sounds.PlayOneShot(Hit);
    }
    public void SoundShot()
    {
        Sounds.PlayOneShot(Shot);
    }
    public void ToggleMusic()
    {
        Sounds.mute = !Sounds.mute;
    }
    public void MusicVolume(float volume)
    {
        Sounds.volume = volume;
    }
}
