using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Alien : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();
    GameObject helloCard;

    private void Start()
    {
        GridRow.Add(A);
    }

    public void SayHello()
    {
        helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
        SoundManager.playSound(SoundManager.alienHello);
    }
    private void SetGridParent(GameObject block)
    {
        block.transform.SetParent(GridRow[0], false);
    }
}
