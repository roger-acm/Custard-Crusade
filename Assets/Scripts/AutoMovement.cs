using UnityEngine;
using System.Collections;


public class AutoMovement : MonoBehaviour
{

    public float speed = 0.05f;
    //public Transform target;

    // use this for initialization
    void start()
    {

    }

    //// Update is called once per frame
    ////void Update () {
    ////	transform.Translate (Vector3.forward * Input.GetAxis ("Mouse X") * Time.deltaTime * speed);
    ////}

    //void Update()
    //{
    //    float direction = Input.GetAxis("Mouse X");
    //    transform.localPosition += speed * direction;
    //    var directionVector = new Vector3(Input.GetAxis("Mouse X"), 0, Input.GetAxis("Mouse Y"));
    //

    //transform.localPosition += speed * directionVector;
    //}
    //void Update()
    //{
    //    float rotLeftRight = Input.GetAxis("Mouse X");
    //    float rotUpDown = Input.GetAxis("Mouse Y");
    //    //float yaw = Input.GetAxis("Mouse Z");
    //    transform.Rotate(rotUpDown, 0, rotLeftRight);
    //    Vector3 direction = new Vector3(speed, speed, speed);
    //    direction = transform.rotation * direction;
    //    transform.localPosition += direction;
    //}

    //void Update()
    //{

    //    var rot = Cardboard.SDK.HeadRotation;
    //    //if (target == null)
    //    //{
    //    //    transform.localRotation = rot;
    //    //}
    //    //else
    //    {
    //        transform.rotation = rot * target.rotation;
    //        Vector3 direction = new Vector3(speed, speed, speed);
    //        direction = transform.rotation * direction;
    //        transform.localPosition += direction;
    //    }
    //}

    //public float speed = 100.0f;

    //void Update()
    //{
    //    float deltaSpeed = Time.deltaTime * speed;
    //    float aroundYAxis = Input.GetAxis("Mouse X") * deltaSpeed;
    //    float aroundXAxis = -Input.GetAxis("Mouse Y") * deltaSpeed;
    //    transform.RotateAround(transform.position, transform.right, aroundXAxis);
    //    transform.RotateAround(transform.position, Vector3.up, aroundYAxis);
    //    //Vector3 direction = new Vector3(speed, speed, speed);
    //    //direction = transform.rotation * direction;
    //    //transform.localPosition += direction;
    //}

   
}
