using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public static int scoreValue;
    public static int circlesDestroyed;
    public TextMeshProUGUI currentScore;

    // Start is called before the first frame update
    void Start()
    {
        currentScore = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentScore.text = scoreValue.ToString();
    }

    public static void IncreaseScore()
    {
        int combo = ComboController.GetCombo();
        if (combo == 0)
        {
            scoreValue += 1;
            circlesDestroyed += 1;
        }
        else
        {
            scoreValue += (1 * combo);
            circlesDestroyed += 1;
        }
    }
    public static int GetScore()
    {
        return scoreValue;
    }

}
