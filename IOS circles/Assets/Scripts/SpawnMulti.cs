using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMulti : MonoBehaviour
{
    public GameObject circleM;
    public float spawnRate = 10;
    private Vector2 screenBounds;
    private float fix = 1.2F;

    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(circleWave());
    }


    private void spawn()
    {
        GameObject circle = Instantiate(circleM) as GameObject;
        circle.transform.position = new Vector2(Random.Range(-fix, fix), screenBounds.y + 1);
    }

    IEnumerator circleWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            spawn();
        }
    }
}
