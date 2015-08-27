using UnityEngine;
using System.Collections;

public class LoginForm : MonoBehaviour {

	public static string email = "";

	public static string accessKey = "";

		void OnGUI()
	{
		Rect rect0 = new Rect(180, 10, 400, 30);
		if (GUI.Button(rect0, "Click to get your access key by PayPal!"))
		{
			Application.OpenURL("https://jo-pp-ruby-demo.herokuapp.com/unity");
		}

		Rect rect1 = new Rect(10, 50, 400, 30);
		GUI.Label(rect1, "Your PayPal email address:");
		Rect rect2 = new Rect(180, 50, 400, 30);
		email = GUI.TextField(rect2, email, 100);

		Rect rect3 = new Rect(10, 90, 400, 30);
		GUI.Label(rect3, "Your obtained access key:");
		Rect rect4 = new Rect(180, 90, 400, 30);
		accessKey = GUI.TextField(rect4, accessKey, 100);

		Rect rect5 = new Rect(180, 130, 400, 30);
		if (GUI.Button(rect5, "Click to start the game!"))
		{
			Application.LoadLevel("Teddy Bear Bazooka");
		}
	}

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
		
}
