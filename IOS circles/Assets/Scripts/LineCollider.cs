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

        if(this.gameObject.tag == col.gameObject.tag)
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
        }
        else
        {
           // Physics2D.IgnoreCollision(col.GetComponent<Collider2D>(), GetComponent<Collider>());
        }
     /**   if (col.gameObject.name == "circleB(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
            //score.increase();
        }
        if (col.gameObject.name == "circleG(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
           // score.increase();
        }
        if (col.gameObject.name == "circleP(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
          //  score.increase();
        }
        if (col.gameObject.name == "circleR(Clone)")
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
          //  score.increase();
        } */
    }
}
