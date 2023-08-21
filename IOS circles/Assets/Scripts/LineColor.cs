using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColor : MonoBehaviour
{
    Material material;
    Renderer renderer;
    public int counter;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<LineRenderer>().material;
        renderer = GetComponent<Renderer>();
        counter = 0;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("Test", 1f, 5f);
        // if (timer)
        // {
        //     timer += Time.deltaTime;
        //     // material.color = Color.black;
        //     renderer.material.color = Color.red;
        // }
        // else
        // {
        //     counter++;
        // }
    }

    void Test()
    {
        if (counter % 5 == 1)
        {
            renderer.material.color = Color.red;
            counter++;
        }
        else
        {
            renderer.material.color = Color.blue;
            counter++;
        }
    }
}
