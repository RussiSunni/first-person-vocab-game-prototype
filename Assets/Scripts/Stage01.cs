using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage01 : MonoBehaviour
{
    public Transform A;
    List<Transform> GridRow = new List<Transform>();

    public static bool isWayBlocked;

    private void Start()
    {
        GridRow.Add(A);
    }
    public void GridTrigger(Vector2 gridNumber, int direction)
    {
        //Debug.Log(gridNumber);
        // Debug.Log(direction);

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
                    var alienScript1 = GameObject.Find("Alien").GetComponent<Alien>();
                    alienScript1.SayHello();
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
                    var elfScript1 = GameObject.Find("Elf").GetComponent<Elf>();
                    elfScript1.SayHello();
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
        else if (gridNumber == new Vector2(6, 0))
        {
            switch (direction)
            {
                case 0:
                    break;
                case 1:
                    isWayBlocked = true;
                    break;
                case 2:
                    break;
                case 3:
                    isWayBlocked = false;
                    break;
            }
        }
        else if (gridNumber == new Vector2(7, 0))
        {

        }
        else if (gridNumber == new Vector2(8, 0))
        {
            // SoundManager.playSound(SoundManager.musicEndStage);
            Debug.Log("complete");
            SceneManager.LoadScene("End Stage");
        }



        else if (gridNumber == new Vector2(3, 1))
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

        else if (gridNumber == new Vector2(3, 2))
        {
            switch (direction)
            {
                case 0:
                    isWayBlocked = true;
                    break;
                case 1:
                    break;
                case 2:
                    isWayBlocked = false;
                    break;
                case 3:
                    break;
            }
        }
    }
}