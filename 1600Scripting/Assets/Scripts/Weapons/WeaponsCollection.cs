using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WeaponsCollection : ScriptableObject
{

    public List<WeaponObject> Weapons;

    public void CollectWeapon(WeaponObject weapon)
    {
        Weapons.Add(weapon);

        foreach (var item in Weapons)
        {
            Debug.Log(item);
            if (item.name == "Sword")
            {
                Debug.Log("You have the best Weapon!!!");
            }
        }
    }

}
