using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (this.GetComponent<ParticleSystem>().isPlaying)//this.particleSystem.isPlaying)
        {
            this.GetComponent<ParticleSystem>().Stop(); 
        }
    }
    private void OnDestroy()
    {
        this.GetComponent<ParticleSystem>().Play();
    }
}
