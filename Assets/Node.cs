using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Node[] ConnectsTo;

    
    private void OnDrawGizmos()
    {
        //if (!Application.isPlaying) return;

        foreach (Node n in ConnectsTo)
        {
            Gizmos.color = Color.red;

            Gizmos.DrawRay(transform.position, (n.transform.position - transform.position).normalized * 4);

            //Gizmos.color = Color.blue;
            //Gizmos.DrawLine(transform.position, n.transform.position);
        }
    }
}
