﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadLevel (string name)
	{
		Debug.Log ("Level load requested for:" + name);
		Application.LoadLevel(name);
	}
	public void QuitRequest() {
		Debug.Log("Requested to quit");
		Application.Quit();
	}
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void LevelLose (){
		Application.LoadLevel("Lose");	
	}

}

