using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyHelp : MonoBehaviour
{
    bool isSelected;
    GameObject selectedObject, catCard;
    public Transform A;
    RaycastHit hit;


    void Update()
    {
        if (FairyCall.isFairyCalled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100))
                {
                    if (!isSelected)
                    {
                        isSelected = true;
                        Debug.Log(hit.transform.gameObject.name);

                        selectedObject = hit.transform.gameObject;
                        selectedObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.5f, 0, 1);

                        if (hit.transform.gameObject.name == "Cat")
                        {
                            if (A.childCount == 0)
                            {
                                catCard = Instantiate(Resources.Load("Prefabs/Cat")) as GameObject;
                                SetGridParent(catCard);
                                //SoundManager.playSound(SoundManager.elfHello);
                            }
                        }
                    }
                    else
                    {
                        isSelected = false;
                        hit.transform.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
                    }
                }
            }
        }
    }

    private void SetGridParent(GameObject card)
    {
        card.transform.SetParent(A, false);
    }

    public void Deselect()
    {
        if (isSelected)
        {
            isSelected = false;
            selectedObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
            if (A.childCount > 0)
            {
                Destroy(A.transform.GetChild(0).gameObject);
            }
        }
    }

}
