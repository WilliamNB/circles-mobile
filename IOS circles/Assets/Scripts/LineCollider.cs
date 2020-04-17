using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        //Check collision name
        Debug.Log("collision name = " + col.gameObject.name);
        //testing if colliding with wrong color increases fun
        GameObject clicked = GameObject.Find("clicked");
        if (this.gameObject.tag == col.gameObject.tag)
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
        }
    }

    public void RemoveObject(GameObject object1, GameObject object2)
    {
        object1.GetComponent<ParticleSystem>().Play();
        if(PlayerPrefs.GetInt("sound") == 0 )
        {
            object1.GetComponent<AudioSource>().Play();
        }
        object2.GetComponent<ParticleSystem>().Play();
        Destroy(object1.GetComponent<Rigidbody2D>());
        object1.GetComponent<CircleCollider2D>().enabled = false;
        object1.GetComponent<SpriteRenderer>().enabled = false;
        object1.GetComponent<TrailRenderer>().enabled = false;
        object2.GetComponent<SpriteRenderer>().enabled = false;
        object2.GetComponent<TrailRenderer>().enabled = false;
        Destroy(object1, 1);
        Destroy(object2, 1);
    }


}
