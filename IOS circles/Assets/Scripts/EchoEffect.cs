using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;
    private GameObject instance;
    private Vector2 screenBounds;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameObject.name != "clicked") && (gameObject.transform.position.y < screenBounds.y))
        {
            if (timeBtwSpawns <= 0)
            {
                instance = Instantiate(echo, new Vector3(transform.position.x, (float)(transform.position.y + 0.3), transform.position.z), Quaternion.identity);
                instance.transform.SetParent(gameObject.transform, true);
                Destroy(instance, 1.2f);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
