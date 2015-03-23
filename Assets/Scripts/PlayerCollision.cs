using UnityEngine;
using System.Collections;

public class PlayerCollision : MonoBehaviour {

    //void OnCollisionEnter()
    //{
    //    Debug.Log("hit something");
    //}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.name);
    }
}
