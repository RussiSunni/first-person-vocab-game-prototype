using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class V2Alien : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();
    GameObject helloCard;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        GridRow.Add(A);
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        SoundManager.playSound(SoundManager.story01);

        StartCoroutine(SayHello());
    }

    IEnumerator SayHello()
    {
        yield return new WaitForSeconds(4);

        helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
        SoundManager.playSound(SoundManager.alienHello);
    }

    private void SetGridParent(GameObject block)
    {
        block.transform.SetParent(GridRow[0], false);
    }

    public void Exercise01()
    {

        SoundManager.playSound(SoundManager.effectCorrect);
        spriteRenderer.flipX = true;
    }

    void OnMouseDown()
    {
        SoundManager.playSound(SoundManager.alienHey);
    }
}
