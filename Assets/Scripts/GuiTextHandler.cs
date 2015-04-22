﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

namespace Assets.Scripts
{
    public class GuiTextHandler : MonoBehaviour
    {
        public static int score = 0;

        void OnGUI()
        {
            GetTextObjectByName("Score").text = "Score: " + score;
        }

        private Text GetTextObjectByName(string name)
        {
            var canvas = GameObject.Find("Canvas");
            var texts = canvas.GetComponentsInChildren<Text>();
            return texts[0];
        }

        void Update()
        {
            score = PlayerCounter.PlayerScore;
        }
    }
}
