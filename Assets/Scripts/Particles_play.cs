using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles_play : MonoBehaviour

{
    public ParticleSystem PSystem_waterfallClouds;

    // Start is called before the first frame update
    void Start()
    {
        PSystem_waterfallClouds.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
