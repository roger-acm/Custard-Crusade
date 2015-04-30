using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts
{
    public class SendScoreScript : MonoBehaviour
    {
        

        void Start()
        {
            int score = PlayerCounter.PlayerScore;
            string url = "http://custardcrusade.comuf.com/unityuploadscript.php?id=rog&score=" + score;
            WWW www = new WWW(url);
            StartCoroutine(WaitForRequest(www));
        }

        IEnumerator WaitForRequest(WWW www)
        {
            yield return www;

            // check for errors
            if (www.error == null)
            {
                Debug.Log ("WWW Ok!: " + www.text);
            }
            else
            {
                Debug.Log ( "WWW Error: " + www.error);
            }
        }
    }
}