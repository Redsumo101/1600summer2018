using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

    private Rigidbody projectile;
    public FloatData ProjectileSpeed;
    public FloatData ProjectileUpgrade;
    private void OnEnable () {
        projectile = GetComponent<Rigidbody>();
        projectile.AddForce(0,0,ProjectileSpeed.Value);
        Invoke("Deactivate", 2);
	}


    private void Deactivate()
    {
        gameObject.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        ProjectileSpeed = ProjectileUpgrade;
        projectile.AddForce(0, 0, ProjectileSpeed.Value);
    }
	
	
}
