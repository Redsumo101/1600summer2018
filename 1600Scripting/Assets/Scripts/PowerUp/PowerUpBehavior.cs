using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {

    public PowerUpBase PowerUp;

   
    void OnTriggerEnter()
    {
        PowerUp.RunPowerUp();
        gameObject.SetActive(false);
    }
}
