using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCircles : MonoBehaviour
{
    public GameObject circlePrefab1;
    public GameObject circlePrefab2;
    public GameObject circlePrefab3;
    public GameObject circlePrefab4;
    public float spawnRate = 3;
    public bool isInfo;
    private Vector2 screenBounds;
    public float spawnRange = 1.5F;
    private int currentScore;
    private bool increaseContoller = true;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(CircleWave());
    }

    private void Spawn()
    {
        int range = Random.Range(1, 5);
        switch (range)
        {
            case 1:
                GameObject circleG = Instantiate(circlePrefab1) as GameObject;
                // Vector2 location = GenerateSpawnLocation();
                // test.transform.position = location;
                circleG.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 2:
                GameObject circleB = Instantiate(circlePrefab2) as GameObject;
                circleB.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 3:
                GameObject circleP = Instantiate(circlePrefab3) as GameObject;
                circleP.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 4:
                GameObject circleR = Instantiate(circlePrefab4) as GameObject;
                circleR.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
        }

    }

    private void DemoSpawn()
    {
        GameObject test = Instantiate(circlePrefab1) as GameObject;
        test.transform.position = new Vector2(screenBounds.x - 1, screenBounds.y + 1);
    }

    IEnumerator CircleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            if (isInfo)
            {
                DemoSpawn();
            }
            else
            {
                Spawn();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentScore = Score.circlesDestroyed;
        if (currentScore > 1 && currentScore % 5 == 0)
        {
            if (increaseContoller == true)
            {
                IncreaseSpawnRate();
            }
        }
        else
        {
            increaseContoller = true;
        }
    }

    public void IncreaseSpawnRate()
    {
        if (spawnRate > 1)
        {
            spawnRate -= 0.1f;
            increaseContoller = false;
        }
    }

    // private Vector2 GenerateSpawnLocation()
    // {
    //     Vector2 test = new Vector2(screenBounds.x, screenBounds.y + 1);
    //     RaycastHit2D hit = Physics2D.Raycast(test, Vector2.left);
    //     if(hit.collider != null){

    //     }
    //     //if hit spawn inverse of hit x vector
    //     //else spawn random
    //     return test;
    // }
}
