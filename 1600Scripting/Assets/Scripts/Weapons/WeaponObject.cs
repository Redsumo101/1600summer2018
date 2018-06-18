using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu()]
public class WeaponObject : ScriptableObject
{
    public float DamageLevel = 10;

    public float DoDamage()
    {
        return DamageLevel;
        
    }
}
