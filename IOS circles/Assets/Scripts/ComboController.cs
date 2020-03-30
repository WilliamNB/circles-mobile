using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboController : MonoBehaviour
{
    private static int comboMeter;
    private static int comboValue;
    public Text comboScore;


    // Start is called before the first frame update
    void Start()
    {
        comboScore = GetComponent<Text>();
        comboMeter = 0;
        comboValue = 0;
    }

    private void Update()
    {
        comboScore.text = comboValue.ToString();
    }

    public static void ComboReset()
    {
        comboMeter = 0;
        comboValue = 0;
    }

    public static void ComboIncrease()
    {
        comboMeter += 1;
        ComboChange(comboMeter);
    }

    public static void ComboChange(int value)
    {
        if(value <= 35)
        {
            switch (value) {
                case 2:
                    comboValue = 2;
                    break;
                case 5:
                    comboValue = 3;
                    break;
                case 9:
                    comboValue = 4;
                    break;
                case 14:
                    comboValue = 5;
                    break;
                case 20:
                    comboValue = 6;
                    break;
                case 27:
                    comboValue = 7;
                    break;
                case 35:
                    comboValue = 8;
                    break;

            }

        }
        else
        {
            comboValue = 8;
        }
    }

    public static int GetCombo()
    {
        return comboValue;
    }
}
