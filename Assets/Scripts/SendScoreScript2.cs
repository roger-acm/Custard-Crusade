using UnityEngine;
using System.Collections;

namespace Assets.Scripts
{
    public class SendScoreScript2 : MonoBehaviour
    {

        void Start()
        {
            int score = PlayerCounter.PlayerScore;
            Debug.Log(score);
            //string url = "http://www.example.com/unityupdatescript.php?id=ROG&amp;score=" + score;
            string url = "http://custardcrusade.comuf.com/unityuploadscript.php?id=ROG&amp;score=" + score;
            string url2 = @"http://custardcrusade.comuf.com/unityuploadscript.php?id=JOj&score=109";// +score;
            WWW www = new WWW(url2);

            //yield www;
        }
    }
}
