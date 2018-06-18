using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons : MonoBehaviour{
    
    
    public enum WeaponType
    {
        Axe,
        Club,
        Sword,
        Spear,
        Scimitar,
        
    }

    public WeaponObject[] WeaponObjects;
    
    
    public WeaponType CurrentWeapon;

    void Update()
    {
        switch (CurrentWeapon)
        {
         case WeaponType.Axe:
             Debug.Log(WeaponObjects[0].name);
             Debug.Log(WeaponObjects[0].DoDamage());
             break;
         
         case WeaponType.Club:
             Debug.Log(WeaponObjects[1].name);
             Debug.Log(WeaponObjects[1].DoDamage());
             break;
         
         case WeaponType.Scimitar:
             Debug.Log(WeaponObjects[2].name);
             Debug.Log(WeaponObjects[2].DoDamage());
             break;
         
         case WeaponType.Spear:
             Debug.Log(WeaponObjects[3].name);
             Debug.Log(WeaponObjects[3].DoDamage());
             break;
         
         case WeaponType.Sword:
             Debug.Log(WeaponObjects[4].name);
             Debug.Log(WeaponObjects[4].DoDamage());
             break;
         
         
         
         
        }
    }


}