using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{

    public WeaponObject Weapon;
    public WeaponsCollection Collection;

    private void OnTriggerEnter(Collider obj)
    {
        Collection.CollectWeapon(Weapon);
    }
    
}
