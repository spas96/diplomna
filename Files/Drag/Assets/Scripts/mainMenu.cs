using UnityEngine;
using System.Collections;
using UnityEngine.UI;	

public class mainMenu : MonoBehaviour {
	public Button button1;
	public Text buttonText1;
	public Button button2;
	public Text buttonText2;
	public Button button3;
	public Text buttonText3;
	public Button button4;
	public Text buttonText4;
	public Button button5;
	public Text buttonText5;
	public Image loadingBar1;
	public Image loadingBar2;
	public Image loginBar;
	public InputField input;
	private float second;
	private int sec;
	private bool go = false;
	public Camera camera1;
	private float good = (float)800/480; 
	private float better = (float)960/540; 
	private float resolution = (float)Screen.width / Screen.height;
	private float part = 0.125f;
	public Image singlePlayer;
	public Image multiPlayer;
	public GameObject garage;
	public GameObject shop;
	public GameObject options;
	public GameObject stat1;
	public Button FBloginButton;
	public Image FBpic;
	// Use this for initialization
	void Start () {
		Debug.Log (Screen.width+" "+Screen.height);
		buttonText1.text = "PLAY";
		buttonText2.text = "GARAGE";
		buttonText3.text = "SHOP";
		buttonText4.text = "OPTIONS";
		buttonText5.text = "EXIT";
	
		camera1.transform.position = new Vector3 (Screen.width/2f, Screen.height/2f, 0);
		input.transform.position = new Vector3 (Screen.width/2f, Screen.height/2f, 506.8f);
		FBloginButton.transform.position = new Vector3 (Screen.width/2f, Screen.height/2f-35, 506.8f);
		if(resolution==better){
			button1.transform.position = new Vector3 (Screen.width/2f-213f, Screen.height/2-128.5f, 506.8f);
			button2.transform.position = new Vector3 (Screen.width/2f-106.5f, Screen.height/2-128.5f, 506.8f);
			button3.transform.position = new Vector3 (Screen.width/2f, Screen.height/2-128.5f, 506.8f);
			button4.transform.position = new Vector3 (Screen.width/2f+106.5f, Screen.height/2-128.5f, 506.8f);
			button5.transform.position = new Vector3 (Screen.width/2f+213f, Screen.height/2-128.5f, 506.8f);
			loginBar.transform.position = new Vector3 (Screen.width/2f-220f, Screen.height/2+106f, 506.8f);
			FBpic.transform.position = new Vector3 (Screen.width/2f-148f, Screen.height/2+127f, 506.8f);
			loadingBar1.transform.position = new Vector3 (Screen.width/2f+220f, Screen.height/2+106f, 506.8f);
		}
		if(resolution==good){
			button1.transform.localScale = new Vector3 (0.41f,1.5f,1);
			button2.transform.localScale = new Vector3 (0.41f,1.5f,1);
			button3.transform.localScale = new Vector3 (0.41f,1.5f,1);
			button4.transform.localScale = new Vector3 (0.41f,1.5f,1);
			button5.transform.localScale = new Vector3 (0.41f,1.5f,1);

			button1.transform.position = new Vector3 (Screen.width/2f-200f, Screen.height/2-128.5f, 506.8f);
			button2.transform.position = new Vector3 (Screen.width/2f-100, Screen.height/2-128.5f, 506.8f);
			button3.transform.position = new Vector3 (Screen.width/2f, Screen.height/2-128.5f, 506.8f);
			button4.transform.position = new Vector3 (Screen.width/2f+100f, Screen.height/2-128.5f, 506.8f);
			button5.transform.position = new Vector3 (Screen.width/2f+200f, Screen.height/2-128.5f, 506.8f);
			loginBar.transform.position = new Vector3 (Screen.width/2f-203.5f, Screen.height/2+106f, 506.8f);
			FBpic.transform.position = new Vector3 (Screen.width/2f-132f, Screen.height/2+127f, 506.8f);
			loadingBar1.transform.position = new Vector3 (Screen.width/2f+203.5f, Screen.height/2+106f, 506.8f);
		}
	}	
	
	// Update is called once per frame
	void Update () {
		if (go) {
			second = second + Time.deltaTime;
			sec = (int)second;
			if(sec <= 1){
				if(loadingBar2.fillAmount <= part)
					loadingBar2.fillAmount += 0.002f;
			}	
			else{
				go = false;
				sec = 0;
				second = 0;
				if(part<1f)
					part+=0.125f;
			}
		}
		//if(sec <= 1)
		//	loadingBar2.fillAmount += 0.05f;
	}

	public void bar(){
		go = true;

	}

	public void choseGame(){
		singlePlayer.gameObject.SetActive (true);
		multiPlayer.gameObject.SetActive (true);
		//FBpic.gameObject.SetActive (false);
		garage.gameObject.SetActive (false);
		shop.gameObject.SetActive (false);
		options.gameObject.SetActive (false);
		stat.play = false;
		stat1.gameObject.SetActive (false);
	}

}
