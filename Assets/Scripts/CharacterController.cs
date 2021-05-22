using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private enum Direction { North, East, South, West };
    Direction playerDirection;

    public static int playerDirectionInt;

    // Set your parameters in the Inspector.
    public float waitSeconds = 60f;
    public Vector3 targetOffset = Vector3.forward * 10f;
    public float speed = 1f;

    public static Vector2 gridSquare = new Vector2(0, 0);


    void Start()
    {
        playerDirection = Direction.East;
        targetOffset.x = 5f;
        targetOffset.z = 0f;
        playerDirectionInt = 1;
    }

    public void TurnLeft()
    {
        if (playerDirection == Direction.North)
        {
            playerDirection = Direction.West;
            targetOffset.x = -5f;
            targetOffset.z = 0f;
        }
        else if (playerDirection == Direction.West)
        {
            playerDirection = Direction.South;
            targetOffset.x = 0f;
            targetOffset.z = -5f;
        }
        else if (playerDirection == Direction.South)
        {
            playerDirection = Direction.East;
            targetOffset.x = 5f;
            targetOffset.z = 0f;
        }
        else if (playerDirection == Direction.East)
        {
            playerDirection = Direction.North;
            targetOffset.x = 0f;
            targetOffset.z = 5f;
        }

        transform.Rotate(0, -90.0f, 0.0f, Space.Self);

        if (playerDirection == Direction.North)
        {
            playerDirectionInt = 0;
        }
        else if (playerDirection == Direction.East)
        {
            playerDirectionInt = 1;
        }
        else if (playerDirection == Direction.South)
        {
            playerDirectionInt = 2;
        }
        else if (playerDirection == Direction.West)
        {
            playerDirectionInt = 3;
        }

        var scene01Script = GameObject.Find("Code").GetComponent<Scene01>();
        scene01Script.GridTrigger(gridSquare, playerDirectionInt);
    }

    public void TurnRight()
    {
        if (playerDirection == Direction.North)
        {
            playerDirection = Direction.East;
            targetOffset.x = 5f;
            targetOffset.z = 0f;
        }
        else if (playerDirection == Direction.East)
        {
            playerDirection = Direction.South;
            targetOffset.x = 0f;
            targetOffset.z = -5f;
        }
        else if (playerDirection == Direction.South)
        {
            playerDirection = Direction.West;
            targetOffset.x = -5f;
            targetOffset.z = 0f;
        }
        else if (playerDirection == Direction.West)
        {
            playerDirection = Direction.North;
            targetOffset.x = 0f;
            targetOffset.z = 5f;
        }

        transform.Rotate(0, 90.0f, 0.0f, Space.Self);

        if (playerDirection == Direction.North)
        {
            playerDirectionInt = 0;
        }
        else if (playerDirection == Direction.East)
        {
            playerDirectionInt = 1;
        }
        else if (playerDirection == Direction.South)
        {
            playerDirectionInt = 2;
        }
        else if (playerDirection == Direction.West)
        {
            playerDirectionInt = 3;
        }

        var scene01Script = GameObject.Find("Code").GetComponent<Scene01>();
        scene01Script.GridTrigger(gridSquare, playerDirectionInt);

    }

    public void MoveForward()
    {
        if (!Scene01.isWayBlocked)
            StartCoroutine(MoveOverTime());
        else
            SoundManager.playSound(SoundManager.effectBump);
    }

    IEnumerator MoveOverTime()
    {
        // First, wait our defined duration.
        yield return new WaitForSeconds(waitSeconds);

        // Then, pick our destination point offset from our current location.
        Vector3 targetPosition = transform.position + targetOffset;

        // Loop until we're within Unity's vector tolerance of our target.
        while (transform.position != targetPosition)
        {

            // Move one step toward the target at our given speed.
            transform.position = Vector3.MoveTowards(
                  transform.position,
                  targetPosition,
                  speed * Time.deltaTime
             );

            // Wait one frame then resume the loop.
            yield return null;
        }

        // We have arrived. Ensure we hit it exactly.
        transform.position = targetPosition;


        if (playerDirection == Direction.North)
        {
            gridSquare = gridSquare + new Vector2(0, 1);
            playerDirectionInt = 0;
        }
        else if (playerDirection == Direction.East)
        {
            gridSquare = gridSquare + new Vector2(1, 0);
            playerDirectionInt = 1;
        }
        else if (playerDirection == Direction.South)
        {
            gridSquare = gridSquare + new Vector2(0, -1);
            playerDirectionInt = 2;
        }
        else if (playerDirection == Direction.West)
        {
            gridSquare = gridSquare + new Vector2(-1, 0);
            playerDirectionInt = 3;
        }



        var scene01Script = GameObject.Find("Code").GetComponent<Scene01>();
        scene01Script.GridTrigger(gridSquare, playerDirectionInt);
        //Scene01.GridTrigger(gridSquare, playerDirectionInt);

        //var checkTagScript = GameObject.Find("Main Camera").GetComponent<CheckTag>();
        //checkTagScript.CheckNPCTag();
    }
}



