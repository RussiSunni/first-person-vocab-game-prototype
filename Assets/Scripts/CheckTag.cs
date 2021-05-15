using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTag : MonoBehaviour
{
    public GameObject Alien, Elf;
    private List<GameObject> NPCs = new List<GameObject>();

    private void Start()
    {
        NPCs.Add(Alien);
        NPCs.Add(Elf); 
    }
    public void CheckNPCTag()
    {
        for (int i = 0; i < NPCs.Count; i++)
        {
            Vector3 viewPos = GetComponent<Camera>().WorldToViewportPoint(NPCs[i].transform.position);
            // Vector3 rearViewPos = camera.WorldToViewportPoint(openings[i].transform.position) + new Vector3(0, 0, -5.4f);
            //  Debug.Log(viewPos);


            if (viewPos.z > 2.4f && viewPos.z < 2.6f && viewPos.x > 0.4f && viewPos.x < 0.6f)
            {
                // var alienScript = GameObject.Find("Alien").GetComponent<Alien>();
                // alienScript.SayHello();
                // break;
            }
            else
            {
                //var alienScript = GameObject.Find("Alien").GetComponent<Alien>();
                //alienScript.SayNothing();
            }
        }
        //Debug.Log(canWalkThroughNextWall);
        // Debug.Log(canWalkThroughPreviousWall);
    }
}
