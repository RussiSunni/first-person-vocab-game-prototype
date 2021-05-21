using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyHelp : MonoBehaviour
{
    GameObject selected;

    void Update()
    {
        if (FairyCall.isFairyCalled)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, 100))
                {
                    Debug.Log(hit.transform.gameObject.name);

                    hit.transform.gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0.5f, 0, 1);

                    if (hit.transform.gameObject.name == "Cat")
                    {
                        Debug.Log(hit.transform.gameObject.name);
                    }
                }
            }
        }
    }

}
