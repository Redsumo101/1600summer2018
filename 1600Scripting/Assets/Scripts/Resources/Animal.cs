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
