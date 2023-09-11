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

    private void Spawn(int range)
    {
        switch (range)
        {
            case 1:
                GameObject circleG = Instantiate(circlePrefab1);
                circleG.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 2:
                GameObject circleB = Instantiate(circlePrefab2);
                circleB.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 3:
                GameObject circleP = Instantiate(circlePrefab3);
                circleP.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
            case 4:
                GameObject circleR = Instantiate(circlePrefab4);
                circleR.transform.position = new Vector2(Random.Range(-spawnRange, spawnRange), screenBounds.y + 1);
                break;
        }

    }

    public void SpawnSpecific(string name)
    {
        switch (name)
        {
            case "circleG(Clone)":
                Spawn(1);
                break;
            case "circleB(Clone)":
                Spawn(2);
                break;
            case "circleP(Clone)":
                Spawn(3);
                break;
            case "circleR(Clone)":
                Spawn(4);
                break;
        }
    }

    private void DemoSpawn(float leftLocation, float rightLocation)
    {
        GameObject circleRight;
        GameObject circleLeft;
        switch (Random.Range(1, 5))
        {
            case 1:
                circleRight = Instantiate(circlePrefab1);
                circleRight.transform.position = new Vector2(rightLocation, screenBounds.y + 1);
                circleLeft = Instantiate(circlePrefab1);
                circleLeft.transform.position = new Vector2(leftLocation, screenBounds.y + 1);
                break;
            case 2:
                circleRight = Instantiate(circlePrefab2);
                circleRight.transform.position = new Vector2(rightLocation, screenBounds.y + 1);
                circleLeft = Instantiate(circlePrefab2);
                circleLeft.transform.position = new Vector2(leftLocation, screenBounds.y + 1);
                break;
            case 3:
                circleRight = Instantiate(circlePrefab3);
                circleRight.transform.position = new Vector2(rightLocation, screenBounds.y + 1);
                circleLeft = Instantiate(circlePrefab3);
                circleLeft.transform.position = new Vector2(leftLocation, screenBounds.y + 1);
                break;
            case 4:
                circleRight = Instantiate(circlePrefab4);
                circleRight.transform.position = new Vector2(rightLocation, screenBounds.y + 1);
                circleLeft = Instantiate(circlePrefab4);
                circleLeft.transform.position = new Vector2(leftLocation, screenBounds.y + 1);
                break;
        }
    }

    IEnumerator CircleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            if (isInfo)
            {
                DemoSpawn((float)screenBounds.x - 5, (float)(screenBounds.x - 0.6));
            }
            else
            {
                Spawn(Random.Range(1, 5));
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
