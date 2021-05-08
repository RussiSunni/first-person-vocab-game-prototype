using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckAnswer : MonoBehaviour
{
    public Transform A, B, C, D, E, F, G, H;

    public void Go()
    {
        //  if (cameraPos.z == -5.4f && cameraPos.x == 0f && direction == "north")
        {
            if (A.transform.GetChild(0).gameObject.name == "Hello(Clone)")
            {
                print("test");
            }
        }
    }
}