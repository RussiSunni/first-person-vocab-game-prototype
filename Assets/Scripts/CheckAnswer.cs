using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public Transform A, B, C, D, E, F, G, H;

    public void Go()
    {
        if (CharacterController.gridSquare == new Vector2(3, 1) && CharacterController.playerDirectionInt == 0)
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)")
            {
                var fairyScript = GameObject.Find("Fairy").GetComponent<Fairy>();
                fairyScript.Exercise01();
            }
        }
    }
}