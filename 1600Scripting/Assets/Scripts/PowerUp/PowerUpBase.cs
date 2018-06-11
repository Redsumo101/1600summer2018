using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBase : ScriptableObject {
<<<<<<< HEAD
    [Range(-10, 10)] public float PowerLevel = 10.0f;
	
		private void OnEnable() {

        Debug.Log("PowerUp");
	}
=======

    public Animal AnyAnimal;

    public float PowerLevel = 1.0f;

    public void RunPowerUp ()
    {
        AnyAnimal.Health += PowerLevel;
    }
>>>>>>> master
}
