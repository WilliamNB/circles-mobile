using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject circlePrefab;
    private Vector2 screenBounds;
    private float fix = 1.2F;
    private int limit = 1;
    private int spawned = 0;
    private GameObject[] numOfCircles;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    private void spawn()
    {
        GameObject test = Instantiate(circlePrefab) as GameObject;
        test.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
        
              
    }

    // Update is called once per frame
    void Update()
    {
        //spawn at half way
        if (transform.position.y < 1 && spawned < limit)
        {
            //prevented circles spawned lik this spawning more
            if (this.name == ("circleB(Clone)") || this.name == ("circleG(Clone)") || this.name == ("circleP(Clone)") || this.name == ("circleR(Clone)") )
            {

                numOfCircles = GameObject.FindGameObjectsWithTag(this.tag);
                //to only spawn if there isnt already a circle of the same colour
                // THERE IS ALWAYS ONE OBJECT WITH THIS TAG OFFSCREEN
                if (numOfCircles.Length < 3)
                 {
                    spawn();
                    spawned += 1;
                 }
            }
        } 
    }
}
