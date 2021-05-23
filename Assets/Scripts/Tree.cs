using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    private void Update()
    {
        if (CharacterController.playerDirectionInt == 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }
        else if (CharacterController.playerDirectionInt == 1)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
        else if (CharacterController.playerDirectionInt == 2)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else if (CharacterController.playerDirectionInt == 3)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
    }

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.effectTree);
    }
}
