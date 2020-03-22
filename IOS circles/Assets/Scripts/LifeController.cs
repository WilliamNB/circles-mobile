using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{
    public static Sprite Grey;
    private static bool BLife;
    private static bool GLife;
    private static bool PLife;
    private static bool RLife;


    void Start()
    {
         BLife = true;
         GLife = true;
         PLife = true;
         RLife = true;
    }

  /*  private void Update()
    {
        if (GameObject.FindGameObjectWithTag("circleB").transform.position.y < -5.5)
        {
            LoseLife(1);
        }
        if (GameObject.FindGameObjectWithTag("circleG").transform.position.y < -5.5)
        {
            LoseLife(2);
        }
        if (GameObject.FindGameObjectWithTag("circleP").transform.position.y < -5.5)
        {
            LoseLife(3);
        }
        if (GameObject.FindGameObjectWithTag("circleR").transform.position.y < -5.5)
        {
            LoseLife(4);
        }
    } */

    public static void LoseLife(int colour)
    {
        switch (colour)
        {
            case 1:
                if(BLife == true)
                {
                    SetLife(colour);
                    GameObject.Find("B Life").GetComponent<SpriteRenderer>().sprite = Grey;
                }
                else
                {
                    EndGame();
                }
                break;
            case 2:
                if (GLife == true)
                {
                    SetLife(colour);
                    GameObject.Find("G Life").GetComponent<SpriteRenderer>().sprite = Grey;
                }
                else
                {
                    EndGame();
                }
                break;
            case 3:
                if (PLife == true)
                {
                    SetLife(colour);
                    GameObject.Find("P Life").GetComponent<SpriteRenderer>().sprite = Grey;
                }
                else
                {
                    EndGame();
                }
                break;
            case 4:
                if (RLife == true)
                {
                    SetLife(colour);
                    GameObject.Find("R Life").GetComponent<SpriteRenderer>().sprite = Grey;
                }
                else
                {
                    EndGame();
                }
                break;
        }
    }

    private static void SetLife(int colour)
    {
        switch (colour)
        {
            case 1:
                BLife = false;
                break;
            case 2:
                GLife = false;
                break;
            case 3:
                PLife = false;
                break;
            case 4:
                RLife = false;
                break;
        }
    }

    private static void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
