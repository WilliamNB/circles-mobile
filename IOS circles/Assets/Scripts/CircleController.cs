using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleController : MonoBehaviour
{
    private Vector2 screenBounds;
    private int state = 0;


    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        if (this.GetComponent<ParticleSystem>().isPlaying)//this.particleSystem.isPlaying)
        {
            this.GetComponent<ParticleSystem>().Stop();
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {

                if (hit.transform.position.x == this.transform.position.x)
                {
                    this.setState(1);
                    this.name = "clicked";
                }
            }
        }

        if (state == 1)
        {
            //this.GetComponent<Rigidbody2D>().gravityScale = 0;
            Destroy(this.GetComponent<Rigidbody2D>());
            Destroy(this.GetComponent<CircleCollider2D>());
        }

    }

    private void setState(int value)
    {
        state = value;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("enter collision");
        if (col.gameObject.tag == "despawn")
        {
            Debug.Log("in if statement");
            Destroy(this.gameObject);
        }
    }
}
