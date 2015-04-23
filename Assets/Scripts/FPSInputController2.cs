﻿using UnityEngine;
using System.Collections;

public class FPSInputController2 : MonoBehaviour {

	private CharacterMotor motor;
	public bool checkAutoWalk = false;
	
	// Use this for initialization
	void Awake()
	{
		motor = GetComponent<CharacterMotor>();
	}

    void OnCardboardTrigger()
    {
        checkAutoWalk = !checkAutoWalk;
    }
	
	// Update is called once per frame
    void Update()
    {
        // Get the input vector from keyboard or analog stick
        Vector3 directionVector;
        if (!checkAutoWalk)
        {
            directionVector = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        }
        else
        {
            directionVector = new Vector3(0, 0, 1);
        }

        if (directionVector != Vector3.zero)
        {
            // Get the length of the directon vector and then normalize it
            // Dividing by the length is cheaper than normalizing when we already have the length anyway
            float directionLength = directionVector.magnitude;
            directionVector = directionVector / directionLength;

            // Make sure the length is no bigger than 1
            directionLength = Mathf.Min(1.0f, directionLength);

            // Make the input vector more sensitive towards the extremes and less sensitive in the middle
            // This makes it easier to control slow speeds when using analog sticks
            directionLength = directionLength * directionLength;

            // Multiply the normalized direction vector by the modified length
            directionVector = directionVector * directionLength;
        }

        motor.inputMoveDirection = transform.forward + directionVector;
    }

}
