using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class stat : MonoBehaviour {
	public GameObject statMenuGameObject;
	public GameObject panel;
	public GameObject panel1;
	public GameObject panel2;
	private float good = (float)800/480; 
	private float better = (float)960/540; 
	private float resolution = (float)Screen.width / Screen.height;
	public Text playerName;
	public Text enemyName;
	public Text WinOrLose;
	public Text myTimer;
	public Text enemyTimer;
	public Text myUpgr;
	public Text enemyUpgr;
	public Image disName;
	public Text prize1;
	public Text prize2;
	public Text prize3;
	public static bool play = true;
	public Image fbpic;
	// Use this for initialization
	void Start () {
		if (resolution == good) {
			panel.transform.position = new Vector3 (Screen.width/2-202, Screen.height/2, 506.8f);
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			panel1.transform.localScale = new Vector3 (0.59f, 0.48f, 1);
			panel2.transform.position = new Vector3 (Screen.width/2+202, Screen.height/2, 506.8f);
			
		}
		if (resolution == better) {
			panel.transform.position = new Vector3 (Screen.width/2-219, Screen.height/2, 506.8f);
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			panel2.transform.position = new Vector3 (Screen.width/2+219, Screen.height/2, 506.8f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("stat") == 1) 
			if(play)
				statMenu ();
		if(move.finish == 1){
			myTimer.text = move.timer.ToString("f2");
			enemyTimer.gameObject.SetActive (false);
			myUpgr.gameObject.SetActive (false);
			enemyUpgr.gameObject.SetActive (true);
			WinOrLose.text = "You Win";
			prize1.text = "1000";
			prize2.text = (move.perfectShifts*10).ToString();
			prize3.text = (move.goodShifts*5).ToString();
			playerName.color = Color.green;
			enemyName.color = Color.red;
		}
		if(move.finish == 2){
			enemyTimer.text = move.timer.ToString("f2");
			myTimer.gameObject.SetActive (false);
			enemyUpgr.gameObject.SetActive (false);
			myUpgr.gameObject.SetActive (true);
			WinOrLose.text = "You Lose";
			prize2.text = (move.perfectShifts*10).ToString();
			prize3.text = (move.goodShifts*5).ToString();
			enemyName.color = Color.green;
			playerName.color = Color.red;
		}

		playerName.text = PlayerPrefs.GetString ("name");
	}
	
	public void statMenu(){
		statMenuGameObject.gameObject.SetActive (true);
		disName.gameObject.SetActive (true);
		fbpic.gameObject.SetActive (false);
	}
}
