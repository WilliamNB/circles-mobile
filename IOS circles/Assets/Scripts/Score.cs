using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

   public static int scoreValue = 3;
    public Text currentScore;
    int objectCount;

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
}
