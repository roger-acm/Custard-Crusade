using UnityEngine;
using System.Collections;
using Assets.Scripts;

public class StartMenu : MonoBehaviour {

     //private CardboardHead head;
     public bool magnetDetectionEnabled = true;

    void Start()
    {
        //head = Camera.main.GetComponent<StereoController>().Head;
        CardboardMagnetSensor.SetEnabled(magnetDetectionEnabled);
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    void Update()
    {
        if (!magnetDetectionEnabled)
        {
            return;
        }

        if (Cardboard.SDK.CardboardTriggered)
        {

            Application.LoadLevel(1);
            Assets.Scripts.PlayerCounter.PlayerScore = 0;
            CardboardMagnetSensor.ResetClick();
        }
    }
}
