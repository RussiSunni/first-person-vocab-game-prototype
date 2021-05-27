using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.effectDog);
    }

    public void ChangePosition()
    {
        transform.position = new Vector3(0, 0, 0);
        transform.Rotate(0, 90, 0);
    }
}
