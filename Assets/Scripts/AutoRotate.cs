using UnityEngine;
using System.Collections;

public class AutoRotate: MonoBehaviour
{
	float xSpeed = 50;
	float ySpeed = 50;
	float zSpeed = 50;

		void Start ()
		{
			
		}

		void Update ()
		{
				transform.Rotate (
				xSpeed * Time.deltaTime,
				ySpeed * Time.deltaTime,
				zSpeed * Time.deltaTime
				);
		}
}


