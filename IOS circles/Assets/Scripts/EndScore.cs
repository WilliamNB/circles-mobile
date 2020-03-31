using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndScore : MonoBehaviour
{
       public static int scoreValue;
       public Text finalScore;

        void Start()
        {
            Debug.Log("in start");
            finalScore = GetComponent<Text>();

            scoreValue = 0;
        }

        void Update()
        {
            finalScore.text = scoreValue.ToString();
        }

        public static void SetScore(int score)
        {
            scoreValue = score;
        }

        
}
