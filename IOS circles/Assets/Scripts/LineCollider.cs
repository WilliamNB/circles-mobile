using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     // if (Input.GetMouseButtonUp(0))
       // {
         //   Destroy(this.gameObject);
           // Destroy(GameObject.Find("clicked"));
      //  }
    }

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

        }
        else
        {
            Destroy(this.gameObject);
            RemoveObject(col.gameObject, clicked);
        }

       /* switch (this.gameObject.layer)
        {
            case 9: //blue
                Physics2D.IgnoreLayerCollision(9, 10, true);
                Physics2D.IgnoreLayerCollision(9, 11, true);
                Physics2D.IgnoreLayerCollision(9, 12, true);
                break;
            case 10: //green
                Physics2D.IgnoreLayerCollision(10, 9, true);
                Physics2D.IgnoreLayerCollision(10, 11, true);
                Physics2D.IgnoreLayerCollision(10, 12, true);
                break;
            case 11: //purple
                Physics2D.IgnoreLayerCollision(11, 9, true);
                Physics2D.IgnoreLayerCollision(11, 10, true);
                Physics2D.IgnoreLayerCollision(11, 12, true);
                break;
            case 12: //red
                Physics2D.IgnoreLayerCollision(12, 9, true);
                Physics2D.IgnoreLayerCollision(12, 10, true);
                Physics2D.IgnoreLayerCollision(12, 11, true);
                break;
        } */
    }

    public void RemoveObject(GameObject object1, GameObject object2)
    {
        Destroy(object1.GetComponent<Rigidbody2D>());
        object1.GetComponent<CircleCollider2D>().enabled = false;
        object1.GetComponent<SpriteRenderer>().enabled = false;
        object1.GetComponent<TrailRenderer>().enabled = false;
        object1.GetComponent<ParticleSystem>().Play();
        object2.GetComponent<SpriteRenderer>().enabled = false;
        object2.GetComponent<TrailRenderer>().enabled = false;
        object2.GetComponent<ParticleSystem>().Play();
        Destroy(object1, 1);
        Destroy(object2, 2);
    }

}
