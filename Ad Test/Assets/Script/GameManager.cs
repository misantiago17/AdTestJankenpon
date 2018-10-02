using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	// Use this for initialization

	public void LoadScene(string sceneName){
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
