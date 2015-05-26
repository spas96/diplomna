using System;
using UnityEngine;
using UnityEngine.Advertisements;

public class Ads : MonoBehaviour {
	private bool once = true;
	private bool button = false;
	void Awake() {
		if (Advertisement.isSupported) {
			Advertisement.allowPrecache = true;
			Advertisement.Initialize ("24046", false);
		} else {
			Debug.Log("Platform not supported");
		}
	}

	void Update(){
		//PlayerPrefs.DeleteKey ("showAds");

		if (move.finish == 1 || move.finish == 2) {
			if(once){
				PlayerPrefs.SetInt("showAds", PlayerPrefs.GetInt ("showAds")+1);
				Debug.Log("THISSS: "+PlayerPrefs.GetInt ("showAds"));
				once = false;
			}
		}

		if ((PlayerPrefs.GetInt ("showAds") == 3 && Advertisement.isReady())) {
			Advertisement.Show(null, new ShowOptions {
				pause = true,
				resultCallback = result => {
					Debug.Log(result.ToString());
					PlayerPrefs.SetInt("showAds", 0);
				}

			});

		}
	}
	
	/*void OnGUI() {
		if(GUI.Button(new Rect(10, 10, 150, 50), Advertisement.isReady() ? "Show Ad" : "Waiting...")) {
			// Show with default zone, pause engine and print result to debug log
			button = true;
		}
	}*/
}