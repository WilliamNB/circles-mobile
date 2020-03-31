using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsHS : MonoBehaviour
{

    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = GetComponent<Text>();

    }

    private void Update()
    {
        if (Score.GetScore() > PlayerPrefs.GetInt("Highscore"))
        {
            highScore.text = "High Score";
        }
    }
}
