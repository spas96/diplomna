using UnityEngine;
using System.Collections;

public class moveEnemy : MonoBehaviour {
	private float speed = Random.Range(0.49f, 0.51f);
	private bool start = false;
	private bool once = true;
	move playerScript;



	// Use this for initialization
	void Start () {

		GameObject thePlayer = GameObject.FindGameObjectWithTag ("Player");
		playerScript = thePlayer.GetComponent <move>();
	}
	
	// Update is called once per frame
	void Update () {

		if(PlayerPrefs.GetInt ("subLevel")==1){
			if(once){
				speed = Random.Range(0.54f, 0.56f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==2){
			if(once){
				speed = Random.Range(0.64f, 0.66f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==3){
			if(once){
				speed = Random.Range(0.69f, 0.71f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==4){
			if(once){
				speed = Random.Range(0.79f, 0.81f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==5){
			if(once){
				speed = Random.Range(0.84f, 0.86f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==6){
			if(once){
				speed = Random.Range(0.94f, 0.96f);
				once = false;
			}
		}
		if(PlayerPrefs.GetInt ("subLevel")==7){
			if(once){
				speed = Random.Range(1.09f, 1.11f);
				once = false;
			}
		}
		if(playerScript.shift>0)
			start = true;


		if (start)
			transform.Translate (new Vector3 (0, 0, speed));	
		if (playerScript.perfectShift) {
			speed+=Random.Range(0.04f, 0.06f);
			playerScript.perfectShift=false;
		}
		if (playerScript.goodShift) {
			speed+=Random.Range(0f, 0.2f);
			playerScript.goodShift=false;
		}
		
	}

	
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "FinishLine") {
			if(move.first){
				move.finish = 2;
				move.first = false;
			}
		}
	}
}
