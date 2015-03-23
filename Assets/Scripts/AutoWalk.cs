using UnityEngine;
using System.Collections;

public class AutoWalk : MonoBehaviour
{
    private CardboardHead head;
    private Vector3 startingPosition;
    public bool magnetDetectionEnabled = true;

    void Start()
    {
        head = Camera.main.GetComponent<StereoController>().Head;
        startingPosition = transform.localPosition;
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
            GameObject FPSController = GameObject.Find("Head");
            FPSInputController autowalk = FPSController.GetComponent<FPSInputController>();
            autowalk.checkAutoWalk = !autowalk.checkAutoWalk;
            CardboardMagnetSensor.ResetClick();
        }
    }

}