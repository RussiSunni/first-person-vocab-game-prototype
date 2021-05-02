using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private enum Direction { North, East, South, West };
    Direction playerDirection;

    // Set your parameters in the Inspector.
    public float waitSeconds = 60f;
    public Vector3 targetOffset = Vector3.forward * 10f;
    public float speed = 1f;

    void Start()
    {
        playerDirection = Direction.North;
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
    }

    public void MoveForward()
    {
        StartCoroutine(MoveOverTime());
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
    }
}



