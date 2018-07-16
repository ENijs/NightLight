using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollw : MonoBehaviour {

    public GameObject Knight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(Knight.transform.position.x, 0, -10);
	}
}
