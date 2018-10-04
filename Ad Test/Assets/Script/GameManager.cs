using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public void LoadScene(string sceneName){
		// ajeitar esse highscore dps
		if (sceneName != "Highscore"){
			SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
		}
	}

	 /* Load a Game Player vs. Player */
	public void LoadPlayerXPlayerScene(string sceneName){

		GameInfo.IsAgainstCPU = false;
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

	/* Load a Game Player vs. CPU */
	public void LoadPlayerXCPUScene(string sceneName){

		GameInfo.IsAgainstCPU = true;
		SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
	}

	public void LoadNextScene(string GameScene, string PlayerScene){

		// Check Game Style
		if(GameInfo.IsAgainstCPU){
			PlayerDefinitionScript.Instance.SavePlayerValue(1);
			PlayerDefinitionScript.Instance.GenerateCPUValue();
			SceneManager.LoadScene(GameScene, LoadSceneMode.Single);

		// Check if all players are ready
		} else {
			if (GameInfo.IsFirstPlayerReady){
				PlayerDefinitionScript.Instance.SavePlayerValue(2);
				SceneManager.LoadScene(GameScene, LoadSceneMode.Single);
			} else {
				PlayerDefinitionScript.Instance.SavePlayerValue(1);
				GameInfo.IsFirstPlayerReady = true;
				SceneManager.LoadScene(PlayerScene, LoadSceneMode.Single);
			}
		}

	}
}
