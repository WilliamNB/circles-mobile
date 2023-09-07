using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineColor : MonoBehaviour
{
    //Material material;
    private GameObject line;
    private Renderer renderer;
    public float timer;
    public Material color1;
    public Material color2;
    public Material color3;
    public Material color4;

    // Start is called before the first frame update
    void Start()
    {
        //material = GetComponent<LineRenderer>().material;
        line = GameObject.Find("LineM");
        renderer = line.GetComponent<Renderer>();
        InvokeRepeating("ColorChange", 0f, timer);
    }

    void ColorChange()
    {
        int lineColor = Random.Range(1, 5);

        switch (lineColor)
        {
            case 1:
                renderer.material.color = color1.color;
                break;
            case 2:
                renderer.material.color = color2.color;
                break;
            case 3:
                renderer.material.color = color3.color;
                break;
            case 4:
                renderer.material.color = color4.color;
                break;
        }
    }
}
