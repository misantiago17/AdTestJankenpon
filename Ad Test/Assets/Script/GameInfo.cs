using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameInfo {

	private static bool isPlayingAgainstCPU;
	private static bool isFirstPlayerReady;

	private static PlayerInfo player1;
	private static PlayerInfo player2;

	public static bool IsAgainstCPU {

        get { return isPlayingAgainstCPU; }
        set { isPlayingAgainstCPU = value; }
    }

	public static bool IsFirstPlayerReady {

        get { return isFirstPlayerReady; }
        set { isFirstPlayerReady = value; }
    }

	public static PlayerInfo Player1 {

        get { return player1; }
        set { player1 = value; }
    }

	public static PlayerInfo Player2 {

        get { return player2; }
        set { player2 = value; }
    }


}
