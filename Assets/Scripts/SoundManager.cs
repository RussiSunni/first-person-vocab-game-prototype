using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip alienHello, elfHello, fairyHello, fairyHey, effectCorrect, effectPop, effectPageTurn, effectBump, effectTree, effectCat, effectDog, musicEndStage;
    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        alienHello = Resources.Load<AudioClip>("Sounds/Alien_Hello");
        elfHello = Resources.Load<AudioClip>("Sounds/Elf_Hello");
        fairyHello = Resources.Load<AudioClip>("Sounds/Fairy_Hello");
        fairyHey = Resources.Load<AudioClip>("Sounds/Fairy_Hey");
        effectCorrect = Resources.Load<AudioClip>("Sounds/Effect_Correct");
        effectPop = Resources.Load<AudioClip>("Sounds/Effect_Pop");
        effectPageTurn = Resources.Load<AudioClip>("Sounds/Effect_PageTurn");
        effectTree = Resources.Load<AudioClip>("Sounds/Effect_Tree");
        effectCat = Resources.Load<AudioClip>("Sounds/Effect_Cat");
        effectDog = Resources.Load<AudioClip>("Sounds/Effect_Dog");
        effectBump = Resources.Load<AudioClip>("Sounds/Effect_Bump");

        musicEndStage = Resources.Load<AudioClip>("Sounds/success_long");

    }

    public static void playSound(AudioClip audioclip)
    {
        audioSrc.PlayOneShot(audioclip);
    }
}
