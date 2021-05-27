using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordUI : MonoBehaviour
{
    public GameObject wordTypesPanel, exclamationsPanel, nounsPanel;
    public Transform A, B, C, D, E, F, G, H;
    public Button helloCardBtn, catCardBtn, dogCardBtn;
    public Button exclamationsBtn, nounsBtn;
    public Sprite exclamationsBtnSprite, nounsBtnSprite, helloCardSprite, catCardSprite, dogCardSprite;
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

            SoundManager.playSound(SoundManager.effectPageTurn);
        }

        else if (nounsPanel.GetComponent<CanvasGroup>().interactable == true)
        {
            nounsPanel.GetComponent<CanvasGroup>().interactable = false;
            nounsPanel.GetComponent<CanvasGroup>().alpha = 0f;
            nounsPanel.transform.SetSiblingIndex(0);

            wordTypesPanel.GetComponent<CanvasGroup>().interactable = true;
            wordTypesPanel.GetComponent<CanvasGroup>().alpha = 1f;
            wordTypesPanel.transform.SetSiblingIndex(6);

            SoundManager.playSound(SoundManager.effectPageTurn);
        }
        else
        {
            GetComponent<CanvasGroup>().interactable = false;
            GetComponent<CanvasGroup>().alpha = 0f;
            transform.SetSiblingIndex(0);
        }
    }

    public void TurnOnExclamationsButton()
    {
        exclamationsBtn.interactable = true;
        exclamationsBtn.image.sprite = exclamationsBtnSprite;
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

            SoundManager.playSound(SoundManager.effectPageTurn);
        }
    }

    public void NounsButton()
    {
        if (nounsPanel.GetComponent<CanvasGroup>().interactable == false)
        {
            nounsPanel.GetComponent<CanvasGroup>().interactable = true;
            nounsPanel.GetComponent<CanvasGroup>().alpha = 1f;
            nounsPanel.transform.SetSiblingIndex(6);

            wordTypesPanel.GetComponent<CanvasGroup>().interactable = false;
            wordTypesPanel.GetComponent<CanvasGroup>().alpha = 0f;
            wordTypesPanel.transform.SetSiblingIndex(1);

            SoundManager.playSound(SoundManager.effectPageTurn);
        }
    }

    public void TurnOnNounsButton()
    {
        if (nounsBtn.interactable == false)
        {
            nounsBtn.interactable = true;
            nounsBtn.image.sprite = nounsBtnSprite;
        }
    }
    public void TurnOnHelloButton()
    {
        helloCardBtn.interactable = true;
        helloCardBtn.image.sprite = helloCardSprite;
    }
    public void TurnOnCatButton()
    {
        catCardBtn.interactable = true;
        catCardBtn.image.sprite = catCardSprite;
    }
    public void TurnOnDogButton()
    {
        dogCardBtn.interactable = true;
        dogCardBtn.image.sprite = dogCardSprite;
    }
    public void HelloButton()
    {
        GameObject helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
    }

    public void CatButton()
    {
        GameObject catCard = Instantiate(Resources.Load("Prefabs/Cat")) as GameObject;
        SetGridParent(catCard);
    }

    public void DogButton()
    {
        GameObject dogCard = Instantiate(Resources.Load("Prefabs/Dog")) as GameObject;
        SetGridParent(dogCard);
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
