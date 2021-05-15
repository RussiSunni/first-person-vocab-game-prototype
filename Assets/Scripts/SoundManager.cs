using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip alienHello, elfHello, fairyHello, effectCorrect;
    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        alienHello = Resources.Load<AudioClip>("Sounds/Alien_Hello");
        elfHello = Resources.Load<AudioClip>("Sounds/Elf_Hello");
        fairyHello = Resources.Load<AudioClip>("Sounds/Fairy_Hello");
        effectCorrect = Resources.Load<AudioClip>("Sounds/Effect_Correct");
    }

    public static void playSound(AudioClip audioclip)
    {
        audioSrc.PlayOneShot(audioclip);
    }
}
