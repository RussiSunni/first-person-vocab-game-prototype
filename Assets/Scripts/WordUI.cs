using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordUI : MonoBehaviour
{
    public GameObject wordTypesPanel, exclamationsPanel;
    public Transform A, B, C, D, E, F, G, H;
    List<Transform> GridRow = new List<Transform>();

    private void Start()
    {
        GridRow.Add(A);
        GridRow.Add(B);
        GridRow.Add(C);
        GridRow.Add(D);
        GridRow.Add(E);
        GridRow.Add(F);
        GridRow.Add(G);
        GridRow.Add(H);
    }

    public void SwitchButton()
    {
        if (GetComponent<CanvasGroup>().interactable == false)
        {
            GetComponent<CanvasGroup>().interactable = true;
            GetComponent<CanvasGroup>().alpha = 1f;
            transform.SetSiblingIndex(6);
        }
        else if (exclamationsPanel.GetComponent<CanvasGroup>().interactable == true)
        {
            exclamationsPanel.GetComponent<CanvasGroup>().interactable = false;
            exclamationsPanel.GetComponent<CanvasGroup>().alpha = 0f;
            exclamationsPanel.transform.SetSiblingIndex(0);

            wordTypesPanel.GetComponent<CanvasGroup>().interactable = true;
            wordTypesPanel.GetComponent<CanvasGroup>().alpha = 1f;
            wordTypesPanel.transform.SetSiblingIndex(6);
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
    }

    public void HelloButton()
    {
        GameObject helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
    }

    public void HiButton()
    {
        GameObject hiCard = Instantiate(Resources.Load("Prefabs/Hi")) as GameObject;
        SetGridParent(hiCard);
    }


    private void SetGridParent(GameObject block)
    {
        if (GridRow[0].childCount != 0 && GridRow[1].childCount != 0 && GridRow[2].childCount != 0 && GridRow[3].childCount != 0 && GridRow[4].childCount != 0 && GridRow[5].childCount != 0 && GridRow[6].childCount != 0 && GridRow[7].childCount != 0)
        {
            Destroy(block);
        }
        else
        {
            for (int i = 0; i < 8; i++)
            {
                if (GridRow[i].childCount == 0)
                {
                    block.transform.SetParent(GridRow[i], false);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    public void ClearButton()
    {
        for (int i = 0; i < GridRow.Count; i++)
        {
            if (GridRow[i].childCount > 0)
            {
                Destroy(GridRow[i].transform.GetChild(0).gameObject);
            }
        }
    }
}
