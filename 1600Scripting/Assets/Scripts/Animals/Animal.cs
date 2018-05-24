using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {


    public float Speed;
    public int PowerLevel;
    public string PlayerName;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Speed, Speed, Speed);
        transform.Translate(Speed, 0, 0);
	}
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu()]
public class Animal : ScriptableObject {
    public float Health = 1.0f;
    public float Speed = 1.0f;
    public float Strength = 1.0f;
    public int LegCount = 2;


}
