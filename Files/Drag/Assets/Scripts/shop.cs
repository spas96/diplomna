using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shop : MonoBehaviour {
	public Button button1;
	public Button button2;
	public Button button3;
	public Image disName;
	public Image tyersPic;
	public Image gearboxPic;
	public Image enginePic;
	public GameObject panel1;
	public GameObject panel2;
	private float good = (float)800/480; 
	private float better = (float)960/540; 
	private float resolution = (float)Screen.width / Screen.height;
	public bool tyres1 = true;
	public bool gearbox1 = false;
	public bool engine1 = false;
	public Text Price;
	public GameObject statMenuGameObject;
	public GameObject shopMenuGameObject;
	public GameObject optionsMenuGameObject;
	public GameObject garageMenuGameObject;
	public GameObject garageScript;
	public Image singlePlayer;
	public Image multiPlayer;

	// Use this for initialization
	void Start () {
		if (resolution == good) {
			button1.transform.position = new Vector3 (Screen.width/2-201, Screen.height/2+51, 506.8f);
			button2.transform.position = new Vector3 (Screen.width/2-201, Screen.height/2, 506.8f);
			button3.transform.position = new Vector3 (Screen.width/2-201, Screen.height/2-51, 506.8f);
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			panel1.transform.localScale = new Vector3 (0.59f, 0.48f, 1);
			panel2.transform.position = new Vector3 (Screen.width/2+202, Screen.height/2, 506.8f);

		}
		if (resolution == better) {
			button1.transform.position = new Vector3 (Screen.width/2-218, Screen.height/2+51, 506.8f);
			button2.transform.position = new Vector3 (Screen.width/2-218, Screen.height/2, 506.8f);
			button3.transform.position = new Vector3 (Screen.width/2-218, Screen.height/2-51, 506.8f);
			panel1.transform.position = new Vector3 (Screen.width/2, Screen.height/2, 506.8f);
			panel2.transform.position = new Vector3 (Screen.width/2+219, Screen.height/2, 506.8f);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void shopMenu(){
		PlayerPrefs.DeleteKey ("stat");
		move.timer = 0f;
		statMenuGameObject.gameObject.SetActive (false);
		garageMenuGameObject.gameObject.SetActive (false);
		optionsMenuGameObject.gameObject.SetActive (false);
		garageScript.gameObject.SetActive (false);
		shopMenuGameObject.gameObject.SetActive (true);
		disName.gameObject.SetActive (true);
		singlePlayer.gameObject.SetActive (false);
		multiPlayer.gameObject.SetActive (false);
	}

	public void tyres(){
		tyersPic.gameObject.SetActive (true);
		gearboxPic.gameObject.SetActive (false);
		enginePic.gameObject.SetActive (false);
		Price.text = "100";
		tyres1 = true;
		gearbox1 = false;
		engine1 = false;
	}

	public void gearbox(){
		tyersPic.gameObject.SetActive (false);
		gearboxPic.gameObject.SetActive (true);
		enginePic.gameObject.SetActive (false);
		Price.text = "500";
		tyres1 = false;
		gearbox1 = true;
		engine1 = false;
	}

	public void engine(){
		tyersPic.gameObject.SetActive (false);
		gearboxPic.gameObject.SetActive (false);
		enginePic.gameObject.SetActive (true);
		Price.text = "1000";
		tyres1 = false;
		gearbox1 = false;
		engine1 = true;
	}
}
