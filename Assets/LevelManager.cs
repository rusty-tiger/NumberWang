using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (Application.loadedLevelName == "Game") {
				LoadLevel("Start");
			} else {
				QuitRequest();
			}
		}
	}
	
	public void LoadLevel(string name) {
		Debug.Log ("Level REquest: " + name);
		Application.LoadLevel(name);
	}
	
	public void QuitRequest() {
		Debug.Log ("Plz Quit");
		Application.Quit();
	}
}
