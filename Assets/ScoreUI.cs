using UnityEngine;
using System.Collections;

public class ScoreUI : MonoBehaviour {

	public int scorePlayerTop;
	public int scorePlayerBottom;
	public GUIStyle style;

	void OnGUI()
	{
		float x = Screen.width/2f;
		float y = 140f;
		float width = 300f;
		float height = 20f;
		string text = scorePlayerTop/2 + "\n" + "___" + "\n\n" + scorePlayerBottom/2; // Have to divide score by half due to bug??

		GUI.Label(new Rect (x-(width/2f), y, width, height), text, style);
	}
}
