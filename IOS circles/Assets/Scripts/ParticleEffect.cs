using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.GetComponent<ParticleSystem>().isPlaying)
        {
            this.GetComponent<ParticleSystem>().Stop(); 
        }
    }
    public void StartEffect(int x, int y)
    {
        this.transform.position = new Vector2(x, y);
        this.GetComponent<ParticleSystem>().Play();
    }
}
