using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Alien : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();

    private void Start()
    {
        GridRow.Add(A);
        SayHello();
    }

    public void SayHello()
    {
        GameObject helloCard = Instantiate(Resources.Load("Prefabs/Hello")) as GameObject;
        SetGridParent(helloCard);
    }
    private void SetGridParent(GameObject block)
    {
        block.transform.SetParent(GridRow[0], false);
    }
}
