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
    private float fix = 1.2F;
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
                GameObject test = Instantiate(circlePrefab1) as GameObject;
                test.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
                break;
            case 2:
                GameObject test2 = Instantiate(circlePrefab2) as GameObject;
                test2.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
                break;
            case 3:
                GameObject test3 = Instantiate(circlePrefab3) as GameObject;
                test3.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
                break;
            case 4:
                GameObject test4 = Instantiate(circlePrefab4) as GameObject;
                test4.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
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
}
