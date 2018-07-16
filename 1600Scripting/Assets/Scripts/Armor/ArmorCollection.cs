using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ArmorCollection : ScriptableObject
{

    public List<ArmorObject> Armor;

    public void CollectArmor(ArmorObject armor)
    {
        Armor.Add(armor);
        
        foreach (var protection in Armor)
        {
            Debug.Log(protection);
            if (protection.name == "Helmet")
            {
                Debug.Log("You are all set");
            }
            
            }
        }
    }
    
    


