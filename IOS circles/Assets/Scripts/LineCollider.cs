using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour
{
    public LifeController lifeController;
    public GameObject particleEffect;
    public Color green;
    public Color blue;
    public Color red;
    public Color purple;
    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        //testing if colliding with wrong color increases fun
        GameObject clicked = GameObject.Find("clicked");
        if (this.gameObject.tag == "circleM" || col.gameObject.tag == "circleM")
        {
            Destroy(this.gameObject);
            RemoveObject(col.gameObject, clicked);
            Score.IncreaseScore();
            ComboController.ComboIncrease();

        }
        else if (this.gameObject.tag == (col.gameObject.tag))
        {
            Destroy(this.gameObject);
            RemoveObject(col.gameObject, clicked);
            Score.IncreaseScore();
            ComboController.ComboIncrease();

        }
        else
        {
            Destroy(this.gameObject);
            RemoveObject(col.gameObject, clicked);
            ComboController.ComboReset();
            lifeController.SelectLife(gameObject.tag);
        }
    }

    public void RemoveObject(GameObject object1, GameObject object2)
    {
        FindObjectOfType<AudioManager>().Play("Pop");
        PlayEffect(object1);
        PlayEffect(object2);

        // Destroy(object1.GetComponent<Rigidbody2D>());
        // object1.GetComponent<CircleCollider2D>().enabled = false;
        // object1.GetComponent<SpriteRenderer>().enabled = false;

        // object2.GetComponent<SpriteRenderer>().enabled = false;

        Destroy(object1);
        Destroy(object2);
    }

    private void PlayEffect(GameObject object1)
    {
        GameObject effect1 = Instantiate(particleEffect);
        effect1.transform.position = new Vector2(object1.transform.position.x, object1.transform.position.y);
        var main = effect1.GetComponent<ParticleSystem>().main;
        main.startColor = Color.black;
        // switch (object1.tag)
        // {
        //     case "circleG":
        //         main.startColor = green;
        //         break;
        //     case "circleB":
        //         main.startColor = blue;
        //         break;
        //     case "circleR":
        //         main.startColor = red;
        //         break;
        //     case "circleP":
        //         main.startColor = purple;
        //         break;
        //     case "circleM":
        //         main.startColor = purple;
        //         break;
        // }
    }

}
