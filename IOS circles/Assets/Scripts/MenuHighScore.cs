using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHighScore : MonoBehaviour
{
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        HighScore.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
