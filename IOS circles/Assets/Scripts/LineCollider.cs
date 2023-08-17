using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour
{
    public LifeController lifeController;
    public GameObject particleEffect;
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
        playEffect(object1);
        playEffect(object2);

        Destroy(object1.GetComponent<Rigidbody2D>());
        object1.GetComponent<CircleCollider2D>().enabled = false;
        object1.GetComponent<SpriteRenderer>().enabled = false;
        object1.GetComponent<TrailRenderer>().enabled = false;

        object2.GetComponent<SpriteRenderer>().enabled = false;
        object2.GetComponent<TrailRenderer>().enabled = false;

        Destroy(object1, 1);
        Destroy(object2, 1);
    }

    private void playEffect(GameObject object1)
    {
        GameObject effect1 = Instantiate(particleEffect);
        effect1.transform.position = new Vector2(object1.transform.position.x, object1.transform.position.y);
        var main = effect1.GetComponent<ParticleSystem>().main;
        main.startColor = object1.GetComponent<TrailRenderer>().startColor;
    }




}
