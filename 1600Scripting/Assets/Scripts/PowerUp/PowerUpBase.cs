using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject {

    public Animal AnyAnimal;

    public float PowerLevel = 1.0f;

    public void RunPowerUp ()
    {
        AnyAnimal.Health += PowerLevel;
    }
}
