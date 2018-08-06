using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class ArmorObject : ScriptableObject
{
    public float Durability = 10;

 
    public float TakeDamage()
    {
        return Durability;
    }


}
