using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class settings : MonoBehaviour {
	public Image disName;
	public GameObject panel1;
	public Button button1;
	private float good = (float)800/480; 
	private float better = (float)960/540; 
	private float resolution = (float)Screen.width / Screen.height;
	public GameObject statMenuGameObject;
	public GameObject shopMenuGameObject;
	public GameObject garageMenuGameObject;
	public GameObject settingsMenuGameObject;
	public GameObject garageScript;
	public Image singlePlayer;
	public Image multiPlayer;
	
	// Use this for initialization
	void Start () {
		if (resolution == good) {
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			panel1.transform.localScale = new Vector3 (0.59f, 0.48f, 1);
			button1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			
		}
		if (resolution == better) {
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			button1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void settingsMenu(){
		PlayerPrefs.DeleteKey ("stat");
		move.timer = 0f;
		statMenuGameObject.gameObject.SetActive (false);
		garageMenuGameObject.gameObject.SetActive (false);
		garageScript.gameObject.SetActive (false);
		shopMenuGameObject.gameObject.SetActive (false);
		settingsMenuGameObject.gameObject.SetActive (true);
		button1.gameObject.SetActive (true);
		disName.gameObject.SetActive (true);
		singlePlayer.gameObject.SetActive (false);
		multiPlayer.gameObject.SetActive (false);
	}
}
