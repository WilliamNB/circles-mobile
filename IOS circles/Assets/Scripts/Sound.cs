using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sound : MonoBehaviour
{
    public Sprite on;
    public Sprite off;
    private Image button;
    // Start is called before the first frame update
    void Start()
    {
        button = this.GetComponent<Image>();

        if (PlayerPrefs.GetInt("sound", 0) == 0)
        {
            button.sprite = on;
        }
        else
        {
            button.sprite = off;
        }
    }

    public void Click()
    {
        if(PlayerPrefs.GetInt("sound") == 0)
        {
            PlayerPrefs.SetInt("sound", 1);
            button.sprite = off;
        }else if(PlayerPrefs.GetInt("sound") == 1)
        {
            PlayerPrefs.SetInt("sound", 0);
            button.sprite = on;
        }
        else
        {
            //error
        }
    }
}
