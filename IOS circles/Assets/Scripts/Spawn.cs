using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject circlePrefab;
    public Camera mainCamera;
    private int limit = 1;
    private int spawned = 0;
    private GameObject[] numOfCircles;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //spawn at half way
        if (transform.position.y < 1 && spawned < limit)
        {
            //prevented circles spawned lik this spawning more
            if (this.name is "circleB(Clone)" or "circleG(Clone)" or "circleP(Clone)" or "circleR(Clone)")
            {

                numOfCircles = GameObject.FindGameObjectsWithTag(this.tag);
                //to only spawn if there isnt already a circle of the same colour
                // THERE IS ALWAYS ONE OBJECT WITH THIS TAG OFFSCREEN
                if (numOfCircles.Length < 3)
                {
                    //Spawner();
                    mainCamera.GetComponent<SpawnCircles>().SpawnSpecific(this.name);
                    spawned += 1;
                }
            }
        }
    }
}
