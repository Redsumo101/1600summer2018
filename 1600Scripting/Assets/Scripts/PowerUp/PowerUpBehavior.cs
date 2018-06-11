using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBehavior : MonoBehaviour {
<<<<<<< HEAD
    public PowerUpBase PowerUp;
    private void OnMouseDown()
    {
        Debug.Log(PowerUp.PowerLevel);  
=======

    public PowerUpBase PowerUp;

   
    void OnTriggerEnter()
    {
        PowerUp.RunPowerUp();
        gameObject.SetActive(false);
>>>>>>> master
    }
}
