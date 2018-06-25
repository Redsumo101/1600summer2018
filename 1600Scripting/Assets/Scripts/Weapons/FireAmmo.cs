using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireAmmo : MonoBehaviour {

    public GameObject Ammo;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Ammo);
        }
    }
}
