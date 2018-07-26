using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
//this defines how close the player needs to get to interact with an item or an enemy
    public float radius = 3f;

    private void OnDrawGizmosSelected()
    {
        Gizmos.color =Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
