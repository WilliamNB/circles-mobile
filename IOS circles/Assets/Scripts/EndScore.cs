using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class EndScore : MonoBehaviour
{
    public static int scoreValue;
    public TextMeshProUGUI finalScore;

    void Start()
    {
        Debug.Log("in start");
        finalScore = GetComponent<TextMeshProUGUI>();

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
