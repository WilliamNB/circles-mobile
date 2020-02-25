using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        if (this.GetComponent<ParticleSystem>().isPlaying)//this.particleSystem.isPlaying)
        {
            this.GetComponent<ParticleSystem>().Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;

        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<ParticleSystem>().Play();
            this.GetComponent<SpriteRenderer>().sprite = null;
            //Destroy(this.gameObject);
        }
    }
}
