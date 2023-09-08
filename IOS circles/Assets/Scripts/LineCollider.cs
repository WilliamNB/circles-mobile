using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour
{
    public LifeController lifeController;
    public GameObject particleEffect;
    private Color[] particleColors;

    private Color32 green = new(67, 160, 71, 255);
    private Color32 blue = new(30, 136, 229, 255);
    private Color32 red = new(229, 57, 53, 255);
    private Color32 purple = new(142, 36, 170, 255);

    void Start()
    {
        particleColors = new Color[] { green, blue, red, purple };
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        //testing if colliding with wrong color increases fun
        GameObject clicked = GameObject.Find("clicked");
        if (this.gameObject.tag == "circleM" || col.gameObject.tag == "circleM")
        {
            Destroy(gameObject);
            RemoveObject(col.gameObject, clicked);
            Score.IncreaseScore();
            ComboController.ComboIncrease();

        }
        else if (gameObject.tag == col.gameObject.tag)
        {
            Destroy(gameObject);
            RemoveObject(col.gameObject, clicked);
            Score.IncreaseScore();
            ComboController.ComboIncrease();

        }
        else
        {
            Destroy(gameObject);
            RemoveObject(col.gameObject, clicked);
            ComboController.ComboReset();
            lifeController.SelectLife(gameObject.tag);
        }
    }

    public void RemoveObject(GameObject object1, GameObject object2)
    {
        //this line stops me from playing start from the game scene
        FindObjectOfType<AudioManager>().Play("Pop");
        PlayEffect(object1);
        PlayEffect(object2);

        Destroy(object1);
        Destroy(object2);
    }

    private void PlayEffect(GameObject object1)
    {
        GameObject effect1 = Instantiate(particleEffect);
        effect1.transform.position = new Vector2(object1.transform.position.x, object1.transform.position.y);
        var main = effect1.GetComponent<ParticleSystem>().main;
        Debug.Log("particle colors " + particleColors.Length);
        switch (object1.tag)
        {
            case "circleG":
                main.startColor = particleColors[0];
                break;
            case "circleB":
                main.startColor = particleColors[1];
                break;
            case "circleR":
                main.startColor = particleColors[2];
                break;
            case "circleP":
                main.startColor = particleColors[3];
                break;
            case "circleM":
                main.startColor = particleColors[Random.Range(0, 4)];
                break;
        }
    }

}
