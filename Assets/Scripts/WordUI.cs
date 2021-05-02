using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordUI : MonoBehaviour
{
    public GameObject wordTypesPanel, exclamationsPanel;
    public Transform A;

    public void SwitchButton()
    {
        if (GetComponent<CanvasGroup>().interactable == false)
        {
            GetComponent<CanvasGroup>().interactable = true;
            GetComponent<CanvasGroup>().alpha = 1f;
            transform.SetSiblingIndex(6);
        }
        else
        {
            GetComponent<CanvasGroup>().interactable = false;
            GetComponent<CanvasGroup>().alpha = 0f;
            transform.SetSiblingIndex(0);
        }
    }

    public void ExclamationsButton()
    {
        if (exclamationsPanel.GetComponent<CanvasGroup>().interactable == false)
        {
            exclamationsPanel.GetComponent<CanvasGroup>().interactable = true;
            exclamationsPanel.GetComponent<CanvasGroup>().alpha = 1f;
            exclamationsPanel.transform.SetSiblingIndex(6);

            wordTypesPanel.GetComponent<CanvasGroup>().interactable = false;
            wordTypesPanel.GetComponent<CanvasGroup>().alpha = 0f;
            wordTypesPanel.transform.SetSiblingIndex(1);
        }
        else
        {
            exclamationsPanel.GetComponent<CanvasGroup>().interactable = false;
            exclamationsPanel.GetComponent<CanvasGroup>().alpha = 0f;
            exclamationsPanel.transform.SetSiblingIndex(0);

            wordTypesPanel.GetComponent<CanvasGroup>().interactable = true;
            wordTypesPanel.GetComponent<CanvasGroup>().alpha = 1f;
            wordTypesPanel.transform.SetSiblingIndex(6);
        }
    }

    public void HelloButton()
    {
        GameObject helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        //aBlock.transform.SetParent(A4);
        //setParent1(helloCard);
        helloCard.transform.SetParent(A, false);
    }
}
