﻿using System.Collections;
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

        switch (this.gameObject.layer)
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
        }

        if (this.gameObject.tag == col.gameObject.tag)
        {
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            Destroy(GameObject.Find("clicked"));
            Score.IncreaseScore();
        }
        else
        {
           // Physics2D.IgnoreCollision(col.GetComponent<CircleCollider2D>(), GetComponent<Collider>());
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
