using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyCall : MonoBehaviour
{
    public GameObject fairyBtn;

    public static bool isFairyCalled;

    public void DisplayFairy()
    {
        if (fairyBtn.GetComponent<CanvasGroup>().alpha == 0f)
        {
            isFairyCalled = true;
            fairyBtn.GetComponent<CanvasGroup>().alpha = 1f;
        }
        else
        {
            isFairyCalled = false;
            fairyBtn.GetComponent<CanvasGroup>().alpha = 0f;

            var fairyHelpScript = GameObject.Find("FairyCompanion").GetComponent<FairyHelp>();
            fairyHelpScript.Deselect();
        }
    }
}
