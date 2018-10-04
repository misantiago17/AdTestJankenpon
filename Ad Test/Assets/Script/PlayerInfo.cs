using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Item {	Rock, Paper, Scissor, Random }

public class PlayerInfo {
	string name;
	Item itemChosen;

	public PlayerInfo (string name, Item item){
		this.name = name;
		this.itemChosen = item;
	}
}