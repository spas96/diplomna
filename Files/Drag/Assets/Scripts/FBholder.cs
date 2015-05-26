using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class FBholder : MonoBehaviour {

	public GameObject FBPicture;
	public GameObject FBUserName;
	private Dictionary<string, string> profile = null;

	

	void Awake(){

		FB.Init (SetInit, OnHideUnity);
	}


	private void SetInit(){
		Debug.Log ("FB Init done.");

		if (FB.IsLoggedIn) {
			Debug.Log("FB Logged in");
		}
		else{

		}
	}

	private void OnHideUnity(bool isGameShown){
		if (!isGameShown) {
			Time.timeScale = 0;	
		}else{
			Time.timeScale = 1;
		}
	}

	public void FBlogin(){
		FB.Login ("email", AuthCallback);
	}

	void AuthCallback(FBResult result){
		if (FB.IsLoggedIn) {
			Debug.Log("FB login worked!");		
		}
		else{
			Debug.Log("FB Login fail");
		}
	}

	public void User(){
		FB.API (Util.GetPictureURL ("me", 128, 128), Facebook.HttpMethod.GET, ProfilePic);
		FB.API ("/me?fields=id,first_name",Facebook.HttpMethod.GET,UserName);
	}

	void ProfilePic(FBResult result){
		if (result.Error != null) {
			Debug.Log("Problem get pic");
			FB.API (Util.GetPictureURL ("me", 128, 128), Facebook.HttpMethod.GET, ProfilePic);
			return;
		}

		Image UserAvatar = FBPicture.GetComponent<Image> ();
		UserAvatar.sprite = Sprite.Create (result.Texture, new Rect (0, 0, 128, 128), new Vector2 (0, 0));
	}
	void UserName(FBResult result){
		if (result.Error != null) {
			Debug.Log("Problem get User name");
			FB.API ("/me?fields=id,first_name",Facebook.HttpMethod.GET,UserName);
			return;
		}
	
		profile = Util.DeserializeJSONProfile (result.Text);
		Text UserMsg = FBUserName.GetComponent<Text> ();
		//UserMsg.text = profile["first_name"];
		PlayerPrefs.SetString ("name", profile["first_name"]);
	}

	public void Share(){
		FB.Feed (
			linkCaption: "Can you beat me?",
			picture: "http://www.brandsoftheworld.com/sites/default/files/styles/logo-thumbnail/public/052012/fifthgear_logo.jpg",
			linkName: "I beat them.",
			link: "http://apps.facebook.com/" + FB.AppId + "/?challenge_brag=" + (FB.IsLoggedIn ? FB.UserId : "guest")
			);
	}
	
}


