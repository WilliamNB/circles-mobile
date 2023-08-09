using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboController : MonoBehaviour
{
    private static int comboMeter;
    private static int comboValue;
    public static Text comboScore;
    public static Animator comboAnimator;


    // Start is called before the first frame update
    void Start()
    {
        comboScore = GetComponent<Text>();
        comboMeter = 0;
        comboValue = 0;
        comboAnimator = GetComponent<Animator>();
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
                    ComboAnimation();
                    break;
                case 5:
                    comboValue = 3;
                    ComboAnimation();
                    break;
                case 9:
                    comboValue = 4;
                    ComboAnimation();
                    break;
                case 14:
                    comboValue = 5;
                    ComboAnimation();
                    break;
                case 20:
                    comboValue = 6;
                    ComboAnimation();
                    break;
                case 27:
                    comboValue = 7;
                    ComboAnimation();
                    break;
                case 35:
                    comboValue = 8;
                    ComboAnimation();
                    break;

            }

        }
        else
        {
            comboValue = 8;
        }
    }

    public static void ComboAnimation(){
        comboAnimator?.SetTrigger("play");
    }

    public static int GetCombo()
    {
        return comboValue;
    }
}
