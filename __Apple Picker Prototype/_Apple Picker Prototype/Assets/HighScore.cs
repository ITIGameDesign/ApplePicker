using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {
	static public int score = 1000;
	
	void Update () {
		GUIText gt = this.GetComponent<GUIText>();
		gt.text = "High Score:"+score;
		
	}
}
