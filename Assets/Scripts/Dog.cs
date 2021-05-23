using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.effectDog);
    }
}
