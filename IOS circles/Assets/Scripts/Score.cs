using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public static int scoreValue;
    public Text currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = scoreValue.ToString();
    }

    public static void IncreaseScore()
    {
        scoreValue += 1;
    }
    public static int GetScore()
    {
        return scoreValue;
    }
}
