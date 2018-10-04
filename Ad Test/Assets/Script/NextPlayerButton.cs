using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextPlayerButton : MonoBehaviour {

	public Button NextPlayerBtn;
	public GameManager GM;

	void Start () {

		NextPlayerBtn.onClick.AddListener(() => {
			GM.LoadNextScene("GameScene","PlayerDefinition");
		});
	}

}
