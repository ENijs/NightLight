using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portalScript : MonoBehaviour {
    public float rotationAmplifier;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, Time.deltaTime* rotationAmplifier, Space.World);
    }
}
