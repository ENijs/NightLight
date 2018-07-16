using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losecollider : MonoBehaviour {

    public GameObject player;

private LevelManager levelmanger;

	void OnTriggerEnter2D(Collider2D trigger){
        player.transform.position = new Vector3(0,0,player.transform.position.z);
        Debug.Log("Respawn");
	}
}
