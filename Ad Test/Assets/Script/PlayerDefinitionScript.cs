using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDefinitionScript : MonoBehaviour {
     
	public InputField TextField;
	public Image ItemImage;
	public Button LeftButton;
	public Button RightButton;

	private static PlayerDefinitionScript instance = null;

	private Item currentItem = Item.Random;

	public static PlayerDefinitionScript Instance {
		get { return instance; } 
	}

	private void Awake(){
		// Check if singleton is initialized
		if (instance != null && instance != this) 
         {
             Destroy(this.gameObject);
         }
 
         instance = this;
         DontDestroyOnLoad( this.gameObject );
	}

	// Falta o controle da roda de itens e ajustes visuais

	// Save PlayerInfo in GameInfo
	public void SavePlayerValue(int playerNumber){

		if (currentItem == Item.Random){
			currentItem = (Item)Random.Range(0,2);
		}
		
		if (TextField.text == ""){

			if(GameInfo.IsFirstPlayerReady){
				TextField.text = "Player 2";
			} else {
				TextField.text = "Player 1"; 
			}
		}

		PlayerInfo player = new PlayerInfo(TextField.text,currentItem);

		if (playerNumber == 1){
			GameInfo.Player1 = player;
		} else if (playerNumber == 2) {
			GameInfo.Player2 = player;
		}
	}

	// Generate CPU value if playing against machine
	public void GenerateCPUValue(){

		PlayerInfo CPU = new PlayerInfo("Mr. Robot", (Item)Random.Range(0,2));

		GameInfo.Player2 = CPU;
	}
}
