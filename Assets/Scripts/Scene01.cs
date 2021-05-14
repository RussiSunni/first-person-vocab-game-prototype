using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene01 : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();

    private void Start()
    {
        GridRow.Add(A);
    }
    public void GridTrigger(Vector2 gridNumber, int direction)
    {
        Debug.Log(gridNumber);

        if (GridRow[0].childCount > 0)
        {
            Destroy(GridRow[0].transform.GetChild(0).gameObject);
        }

        if (gridNumber == new Vector2(0, 0))
        {
            switch (direction)
            {
                case 0:
                    break;

                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;
            }
        }
        else if (gridNumber == new Vector2(1, 0))
        {
            switch (direction)
            {
                case 0:
                    var alienScript = GameObject.Find("Alien").GetComponent<Alien>();
                    alienScript.SayHello();
                    break;
                case 1:

                    break;
                case 2:

                    break;

                case 3:

                    break;
            }
        }
        else if (gridNumber == new Vector2(2, 0))
        {
            switch (direction)
            {
                case 0:
                    var elfScript = GameObject.Find("Elf").GetComponent<Elf>();
                    elfScript.SayHello();
                    break;
                case 1:

                    break;
                case 2:

                    break;

                case 3:

                    break;
            }
        }
        else if (gridNumber == new Vector2(0, 0))
        {

        }
        else if (gridNumber == new Vector2(0, 0))
        {

        }
        else if (gridNumber == new Vector2(0, 0))
        {

        }
    }



}