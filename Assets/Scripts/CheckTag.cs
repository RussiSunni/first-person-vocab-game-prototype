using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTag : MonoBehaviour
{
    public GameObject NPC;
    public void CheckNPCTag()
    {
        //  for (int i = 0; i < solidObjects.Length; i++)
        {
            Vector3 viewPos = GetComponent<Camera>().WorldToViewportPoint(NPC.transform.position);
            // Vector3 rearViewPos = camera.WorldToViewportPoint(openings[i].transform.position) + new Vector3(0, 0, -5.4f);
            Debug.Log(viewPos);

            //3D
            if (viewPos.z > 5.3f && viewPos.z < 5.5f && viewPos.x > 0.4f && viewPos.x < 0.6f)
            {
                Debug.Log("found");
            }
            else if (viewPos.z > 2.4f && viewPos.z < 2.6f && viewPos.x > 0.4f && viewPos.x < 0.6f)
            {
                Debug.Log("found");
            }
            else
            {
                Debug.Log("not found");
            }
        }
        //Debug.Log(canWalkThroughNextWall);
        // Debug.Log(canWalkThroughPreviousWall);
    }
}
