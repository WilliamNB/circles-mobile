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

    private ArrayList lives;
    private GameObject playUI;
    private GameObject endUI;
    private int finalScore;
    private int highScore;
    private bool isHS;


    void Start()
    {
        playUI = GameObject.Find("PlayUI");
        endUI = GameObject.Find("EndUI");
        endUI.SetActive(false);

        lives = new ArrayList() { 1, 2, 3, 4 };
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
                if (BLife == true)
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
                lives.Remove(1);
                break;
            case 2:
                GLife = false;
                lives.Remove(2);
                break;
            case 3:
                PLife = false;
                lives.Remove(3);
                break;
            case 4:
                RLife = false;
                lives.Remove(4);
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
            case "circleM":
                if (lives.Count == 0)
                {
                    EndGame();
                }
                else
                {
                    int randomIndex = Random.Range(0, lives.Count);
                    int life = (int)lives[randomIndex];
                    LoseLife(life);
                }
                break;
        }
    }

    private void EndGame()
    {
        highScore = PlayerPrefs.GetInt("Highscore");
        finalScore = Score.GetScore();
        if (finalScore > highScore)
        {
            PlayerPrefs.SetInt("Highscore", finalScore);
        }
        playUI.SetActive(false);
        endUI.SetActive(true);
        EndScore.SetScore(finalScore);
    }

}
