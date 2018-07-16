using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour {

	private LevelManager levelmanger;

	void Start(){
		levelmanger = GameObject.FindObjectOfType<LevelManager>();
	}

	void OnTriggerEnter2D(Collider2D triger){
		Debug.Log("Door Collided");
		print("Door Collided");
		levelmanger.LoadNextLevel();
	}
}