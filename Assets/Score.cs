using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;

	public static int amt = -1000;

	public static int amt_by_hit = 100;

	public static int charge_count = 15;

	public static int charge_rate = 50;

	public static int cur_count = 0;

	// Use this for initialization
	void Start () {
		scoreText.text = amt + " JPY";
	}

	// Update is called once per frame
	void Update () {
		scoreText.text = amt + " JPY";
	}
}
