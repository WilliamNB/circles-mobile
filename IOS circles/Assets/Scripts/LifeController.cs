using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeController : MonoBehaviour
{

    public Sprite Grey;
    public Image image;
    private bool BLife;
    private bool GLife;
    private bool PLife;
    private bool RLife;
    private GameObject playUI;
    private GameObject endUI;
    private int finalScore;


    void Start()
    {
        playUI = GameObject.Find("PlayUI");
        endUI = GameObject.Find("EndUI");
        endUI.SetActive(false);
        BLife = true;
        GLife = true;
        PLife = true;
        RLife = true;
    }

    public void LoseLife(int colour)
    {
        switch (colour)
        {
            case 1:
                if(BLife == true)
                {
                    SetLife(colour);
                    image = GameObject.Find("B Life").GetComponent<Image>();
                    image.sprite = Grey;
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
                    image = GameObject.Find("G Life").GetComponent<Image>();
                    image.sprite = Grey;
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
                    image = GameObject.Find("P Life").GetComponent<Image>();
                    image.sprite = Grey;
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
                    image = GameObject.Find("R Life").GetComponent<Image>();
                    image.sprite = Grey;
                }
                else
                {
                    EndGame();
                }
                break;
        }
    }

    private void SetLife(int colour)
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

    void OnCollisionEnter2D(Collision2D col)
    {
            switch (col.gameObject.tag)
            {
                case "circleB":
                    LoseLife(1);
                    break;
                case "circleG":
                    LoseLife(2);
                    break;
                case "circleP":
                    LoseLife(3);
                    break;
                case "circleR":
                    LoseLife(4);
                    break;
            }
    }

    private void EndGame()
    {
        finalScore = Score.GetScore();
        Debug.Log("final score  " + finalScore);
        playUI.SetActive(false);
        endUI.SetActive(true);
        FinalScore.SetScore(finalScore);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
