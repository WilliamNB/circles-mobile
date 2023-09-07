using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;
    private GameObject instance;
    // private SpriteRenderer spriteRenderer;
    // public Sprite sprite;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // spriteRenderer = echo.GetComponent<SpriteRenderer>();
        // spriteRenderer.sprite = sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.name != "clicked") && (gameObject.transform.position.y < screenBounds.y))
        {
            if (timeBtwSpawns <= 0)
            {
                instance = Instantiate(echo, new Vector3(transform.position.x, (float)(transform.position.y + 0.3), transform.position.z), Quaternion.identity);
                Destroy(instance, 2f);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }

    // private void OnDestroy()
    // {
    //     GameObject[] test = GameObject.FindGameObjectsWithTag("echo");
    //     Debug.Log("echo should be destroyed");
    //     foreach (GameObject i in test)
    //     {
    //         DestroyImmediate(i, true);
    //     }
    //     //DestroyImmediate(echo, true);
    //     // Destroy(instance, 0.1f);
    //     // Destroy(echo, 0.1f);
    // }
}
