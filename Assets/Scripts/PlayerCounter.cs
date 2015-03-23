using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    class PlayerCounter : MonoBehaviour
    {
        public int PlayerScore = 0;
        public AudioSource SweetsEaten;
        public AudioClip bite;


        void OnTriggerEnter(Collider other)
        {
            if (other.tag == ("CandyCane"))
            {
                SweetsEaten.PlayOneShot(bite, 1);
                PlayerScore += 5;
            }
            else if (other.tag == ("Donut"))
            {
                SweetsEaten.PlayOneShot(bite, 1);
                PlayerScore += 10;
            }
        }
    }
}
