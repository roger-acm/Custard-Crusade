using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour
{
    public float xSpeed = 50;
    public float ySpeed = 50;
    public float zSpeed = 50;


    void Update()
    {
        transform.Rotate(
        xSpeed * Time.deltaTime,
        ySpeed * Time.deltaTime,
        zSpeed * Time.deltaTime
        );
    }
}


