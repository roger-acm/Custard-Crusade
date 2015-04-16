using UnityEngine;
using System.Collections;

public class GuiTextHandler : MonoBehaviour {

    //public GameObject gui;
    static int score = 0;
    public int test;

	void OnGUI () {

        GUI.Box(new Rect(Screen.height/2, Screen.width/2, 100, 30), "" + score);
	}

    void Update()
    {
        test = score;
    }
}
