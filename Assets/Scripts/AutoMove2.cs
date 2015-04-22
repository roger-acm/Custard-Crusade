using UnityEngine;
using System.Collections;

public class AutoMove2 : MonoBehaviour {

    public float balloon_speed = 10f;

    public bool checkAutoWalk = false;

    void update()
    {
        if (!checkAutoWalk)
        {

            transform.position += transform.forward * Time.deltaTime * balloon_speed;
        }
    }

    void OnCardboardTrigger()
    {
        checkAutoWalk = !checkAutoWalk;
    }
}
