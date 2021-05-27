using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public Transform A, B, C, D, E, F, G, H;

    public void Go()
    {
        // Alien
        if (CharacterController.gridSquare == new Vector2(1, 0) && CharacterController.playerDirectionInt == 0)
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)")
            {
                var alienScript = GameObject.Find("Alien").GetComponent<Alien>();
                alienScript.Exercise01();
            }
        }

        // Elf
        if (CharacterController.gridSquare == new Vector2(2, 0) && CharacterController.playerDirectionInt == 0)
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)")
            {
                var elfScript = GameObject.Find("Elf").GetComponent<Elf>();
                elfScript.Exercise01();
            }
        }

        // Fairy
        else if (CharacterController.gridSquare == new Vector2(3, 1) && CharacterController.playerDirectionInt == 0)
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)")
            {
                var fairyScript = GameObject.Find("Fairy").GetComponent<Fairy>();
                fairyScript.Exercise01();
            }
        }

        // Dog
        else if (CharacterController.gridSquare == new Vector2(6, 0) && CharacterController.playerDirectionInt == 1)
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)" && B.transform.GetChild(0).gameObject.name == "Dog(Clone)")
            {
                var dogScript = GameObject.Find("Dog").GetComponent<Dog>();
                dogScript.ChangePosition();
                Debug.Log("dog");
            }
        }


        var wordUIScript = GameObject.Find("WordUI").GetComponent<WordUI>();
        wordUIScript.ClearButton();
    }
}