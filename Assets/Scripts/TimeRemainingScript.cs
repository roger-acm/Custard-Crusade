using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeRemainingScript : MonoBehaviour {

    public float gameDuration = 30;
    private Image timeBar;

    void Awake()
    {
        timeBar = GetComponent<Image>();
        timeBar.fillAmount = 1;
    }

	// Update is called once per frame
	void Update () {
        timeBar.fillAmount = (gameDuration - Time.timeSinceLevelLoad) / gameDuration;

        if (timeBar.fillAmount == 0)
        {
            Application.LoadLevel(2);
        }
	}
}
