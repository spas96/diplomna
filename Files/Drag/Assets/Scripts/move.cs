using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class move : MonoBehaviour {
	public Texture2D bar1;
	public Texture2D bar2;
	public Texture2D arrow;
	public Vector2 position;
	public float topSpeed;
	public float stopAngle;
	public float topSpeedAngle;
	public float speed;
	private float partSpeed;

	public Rect windowRect = new Rect(20, 20, 120, 50);
	
	private NetworkManager colourChange;
	public float go;
	private float second;
	private int sec;
	private int i=0;
	private bool perfect = false;
	private bool bad = false;
	private int slowDown = 5;
	private bool start = false;
	public static bool A = false;
	private bool B = false;
	private bool speedDown = false;
	public int shift = 0;
	public bool perfectShift = false;
	public bool goodShift = false;
	public static int finish = 0;
	private bool end = false;
	public float fillAmount;
	private bool once = true;
	public static float timer;
	public Text time;
	public static int perfectShifts;
	public static int goodShifts;
	public static bool first = true;
	// Use this for initialization


	void Start () {
		//Application.OpenURL ("http://www.facebook.com/dialog/feed?app_id=900841676606193&display=popup&redirect_uri=http://www.facebook.com&picture=http://upload.wikimedia.org/wikipedia/en/a/a3/TV-Lost-in-Space-Volume-1-music-CD-1997-cover.jpg&name=Lost In Space&description=Can you beat me?&caption=My score is: ");
	}

	    
	// Update is called once per frame
	void Update () {
		if(play.SingleOrMulti == false){
			if ((NetworkManager.ttt || PhotonNetwork.countOfPlayers == 2)&& shift < 2) {
				A = true;
			}
		}
		time.text = timer.ToString("F2");
		if (finish == 1 || finish == 2) {
			PlayerPrefs.SetInt("stat",1);
			Application.LoadLevel("mainMenu");
		}

		//PlayerPrefs.SetInt("subLevel", 7);
	//PlayerPrefs.DeleteKey ("subLevel");
	//PlayerPrefs.DeleteKey ("upgrade");
		//Image image1 = GetComponent<Image> ();
		if(PlayerPrefs.GetInt ("upgrade")==1){
			if(once){
				go = 0.65f;
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("upgrade")==2){
			if(once){
				go = 0.80f;
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("upgrade")==3){
			if(once){
				go = 1.05f;
				once = false;
			}
		}
		if (end == false) {
			if (finish == 1) {
				end = true;
				Debug.Log ("YOU WINNNN");
				PlayerPrefs.SetInt("subLevel", PlayerPrefs.GetInt ("subLevel")+1);
				Debug.Log("SUBLEVEL: "+ PlayerPrefs.GetInt("subLevel"));
			}
			if (finish == 2) {
				end = true;
				Debug.Log ("YOU LOSEEEEEE");
			}		
		}
		Debug.Log("Shift: "+shift);
		
				if (start) {
						if (speed < 80) {
							if(shift==1)
								speed += 1.5f;	
							if(shift==2)
								speed += 1.3f;
							if(shift==3)
								speed += 1.1f;	
							if(shift==4)
								speed += 0.9f;	
							if(shift==5)
								speed += 0.7f;	
							if(shift>5)
								speed += 0.6f;  

							if (speed < 0) {
								speed = 0;
							}
							
			}
			//Debug.Log ("speed: " + speed);
						
				}
				
				if (perfect) {

						second = second + Time.deltaTime;
						sec = (int)second;

						for (i=0; i<10; i++) {
								if (sec < 2) {
										transform.Translate (new Vector3 (0, 0, .001f));

								} else {
										perfect = false;
										second = 0;
								}
						}
				}
				if (slowDown >= 0){
					if (bad) {
							second = second + Time.deltaTime;
							sec = (int)second;


							for (i=0; i<10; i++) {
									if (sec < 2) {
											transform.Translate (new Vector3 (0, 0, -.001f));
									} else {
											bad = false;
											second = 0;
									}
							}
					}
			}

		if (A) {
			second = second + Time.deltaTime;
			sec = (int)second;
			if(sec==5){
				B = true;
				start=true;
				//speed=20;
				shift = 1;
				A=false;
			}
		}
		
		if (speedDown == false) {
			if (speed > 0) {
				speed -= 0.5f;
			}

			if (speed < 0) {
				speed = 0;
			}
		}

		//}
	//	transform.Translate(new Vector3(0,0,0.5f));
			//speed = go * 10;

		if(B){
			if(finish==0)
				timer += Time.deltaTime;
			transform.Translate (new Vector3 (0, 0, go));
		}

	}

	IEnumerator Pshifts() {
		for(int i=0;i<3;i++){
			yield return new WaitForSeconds(0.33f);
			go+=0.033f;
		}
	}

	IEnumerator Gshifts() {
		for(int i=0;i<3;i++){
			yield return new WaitForSeconds(0.33f);
			go+=0.0166f;
		}
	}

	IEnumerator Bshifts() {
		for(int i=0;i<3;i++){
			yield return new WaitForSeconds(0.33f);
			go-=0.0166f;
		}
	}
	
	void OnGUI () {
		GUI.backgroundColor = Color.clear;
				if (speed < 69) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar1.width, bar1.height), bar1);
				} else {
						GUI.DrawTexture (new Rect (position.x, position.y, bar2.width, bar2.height), bar2);
				}
				if (speed == 70) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar1.width, bar1.height), bar1);
				}
				if (speed == 71) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar2.width, bar2.height), bar2);
				}
				if (speed == 72) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar1.width, bar1.height), bar1);
				}
				if (speed == 73) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar2.width, bar2.height), bar2);
				}
				if (speed == 74) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar1.width, bar1.height), bar1);
				}
				if (speed == 75) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar2.width, bar2.height), bar2);
				}
				if (speed == 76) {
						GUI.DrawTexture (new Rect (position.x, position.y, bar1.width, bar1.height), bar1);
				}

				Vector2 centre = new Vector2 (position.x + bar1.width / 2, position.y + bar1.height / 2);
				var savedMatrix = GUI.matrix;
				var speedFraction = speed / topSpeed;
				var needleAngle = Mathf.Lerp (stopAngle, topSpeedAngle, speedFraction);
				partSpeed = needleAngle / 100;
				//GUIUtility.RotateAroundPivot(needleAngle, centre);
				for (int i=0; i<100; i++) {
						//StartCoroutine(Wait());
						GUIUtility.RotateAroundPivot (partSpeed, centre);

				}
				GUI.DrawTexture (new Rect (centre.x, centre.y - arrow.height / 2, arrow.width, arrow.height), arrow);
				GUI.matrix = savedMatrix;


				
		if(GUI.Button(new Rect(0,0,Screen.width,Screen.height), "")) {

			shift++;
			if(shift<=6){
			
		//perfect
				if(speed >= 73 && speed <= 76){
					Debug.Log("PERFECT!!!!!!!!!!!!!!!");
					perfect = true;
					perfectShift = true;
					perfectShifts+=1;
					//go+=0.1f;
					StartCoroutine(Pshifts());
					if(slowDown<=5){
						slowDown++;
					}
				}
		//good
				if(speed > 69 && speed < 72 || speed >77 && speed <79){
					Debug.Log("GOOD!!!!!!!!!!!!!!!");
					perfect = true;
					goodShift = true;
					goodShifts++;
					StartCoroutine(Gshifts());
					if(slowDown<=5){
						slowDown++;
					}
				}
		//bad
				if(speed<=69 || speed >= 79){
					Debug.Log("BAD!!!!!!!!!!!!!!!");
					bad = true;
					if(slowDown>=0){
						StartCoroutine(Bshifts());
					}
					slowDown--;
				}

					speed-=50;

			}
		}
	}

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "FinishLine") {
			if(first){
				finish = 1;
				first = false;
			}
		}
	}

	public void Reset(){
		PlayerPrefs.DeleteKey ("subLevel");
		PlayerPrefs.DeleteKey ("upgrade");
	}
}
