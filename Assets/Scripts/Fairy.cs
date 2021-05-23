using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();
    GameObject helloCard;

    private void Start()
    {
        GridRow.Add(A);
    }

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.fairyHey);
    }

    public void Exercise01()
    {
        SoundManager.playSound(SoundManager.effectCorrect);
        helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
        StartCoroutine(Exercise01Response());
    }

    private void SetGridParent(GameObject block)
    {
        block.transform.SetParent(GridRow[0], false);
    }

    IEnumerator Exercise01Response()
    {
        yield return new WaitForSeconds(0.5f);
        SoundManager.playSound(SoundManager.fairyHello);
    }
}
