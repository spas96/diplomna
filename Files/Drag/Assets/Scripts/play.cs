using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class play : MonoBehaviour {
	public Image singlePlayer;
	public Image multiPlayer;
	public static bool SingleOrMulti = true;
	// Use this for initialization
	void Start () {
		singlePlayer.transform.position = new Vector3 (Screen.width/2-80, Screen.height/2, 506.8f);
		multiPlayer.transform.position = new Vector3 (Screen.width/2+80, Screen.height/2, 506.8f);	
	}
	
	// Update is called once per frame
	void Update () {
				
	}

	public void Play(){
		move.finish = 0;
		move.first = true;
		move.timer = 0;
		SingleOrMulti = true;
		Application.LoadLevel("singlePlayer1");
		stat.play = true;
		Debug.Log ("play");
		move.A = true;
	}

	public void Multiplayer(){
		move.finish = 0;
		move.first = true;
		move.timer = 0;
		SingleOrMulti = false;
		Application.LoadLevel("multiplayer");
		stat.play = true;
		Debug.Log ("play");
	}


}
